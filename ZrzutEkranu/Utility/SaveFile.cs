using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using ZrzutEkranu.Properties;

namespace ZrzutEkranu.Utility
{
    [Serializable]
    public enum PdfImageOrientation
    {
        Vertical,
        Horizontal,
        Auto
    }

    internal static class SaveFile
    {
        private const int PdfPageWidth = 595;
        private const int PdfPageHeight = 842;
        private const int PdfDpi = 72;

        public static void SaveToImage(Image image)
        {
            var format = Settings.Default.ImageFormat;
            var fileName = GetFileName(Settings.Default.ImageFormat.ToString());

            if (fileName != null)
                image.Save(fileName, format);
        }

        public static void SaveToPdf(Image image)
        {
            var document = new PdfDocument();
            var page = document.AddPage();

            AddImageToPdf(image, page);

            var fileName = GetFileName("PDF");

            if (fileName != null)
                document.Save(fileName);
        }

        private static void AddImageToPdf(Image image, PdfPage page)
        {
            var margin = Settings.Default.PdfMargin;

            using (var gfx = XGraphics.FromPdfPage(page))
            using (var stream = new MemoryStream())
            {
                if (ShouldRotateImage(image))
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                image.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                using (var xImage = XImage.FromStream(stream))
                {
                    double widthOffset;
                    if (ImageFitsPdf(image))
                    {
                        widthOffset = (PdfPageWidth - xImage.PointWidth - 2 * margin) / 2;
                        gfx.DrawImage(xImage, margin + widthOffset, margin);
                    }
                    else
                    {
                        double scaledWidth;
                        double scaledHeight;
                        if (xImage.PointWidth > xImage.PointHeight)
                        {
                            scaledWidth = PdfPageWidth - 2 * margin;
                            scaledHeight = scaledWidth / xImage.PointWidth * xImage.PointHeight;
                        }
                        else
                        {
                            scaledHeight = PdfPageHeight - 2 * margin;
                            scaledWidth = scaledHeight / xImage.PointHeight * xImage.PointWidth;
                        }

                        widthOffset = (PdfPageWidth - scaledWidth - 2 * margin) / 2;
                        gfx.DrawImage(xImage, margin + widthOffset, margin, scaledWidth, scaledHeight);
                    }
                }
            }
        }

        private static bool ShouldRotateImage(Image image)
        {
            var autoRotation = ImageFitsPdf(image) is false
                                   && Settings.Default.PdfImageOrientation == PdfImageOrientation.Auto
                                   && image.Width > image.Height;

            return autoRotation || Settings.Default.PdfImageOrientation == PdfImageOrientation.Vertical;
        }

        private static bool ImageFitsPdf(Image image)
        {
            var maxWidth = PdfPageWidth - 2 * Settings.Default.PdfMargin;
            var maxHeight = PdfPageHeight - 2 * Settings.Default.PdfMargin;
            var dpiWidth = image.Width * PdfDpi / image.HorizontalResolution;
            var dpiHeight = image.Height * PdfDpi / image.VerticalResolution;
            return dpiWidth < maxWidth && dpiHeight < maxHeight;
        }

        private static string GetFileName(string format)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = format.ToUpper() + "(*." + format + ")|*." + format;
            dialog.RestoreDirectory = true;
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }
    }
}