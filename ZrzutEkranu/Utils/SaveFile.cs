using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZrzutEkranu.Utils
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
            var format = Properties.Settings.Default.ImageFormat;
            var fileName = GetFileName(Properties.Settings.Default.ImageFormat.ToString());

            if (fileName != null)
                image.Save(fileName, format);
        }

        public static void SaveToPdf(Image capturedImage)
        {
            var document = new PdfDocument();
            var page = document.AddPage();

            AddImageToPdf(capturedImage, page);

            var fileName = GetFileName("PDF");

            if (fileName != null)
                document.Save(fileName);
        }

        private static void AddImageToPdf(Image image, PdfPage page)
        {
            var margin = Properties.Settings.Default.PdfMargin;

            using (var gfx = XGraphics.FromPdfPage(page))
            using (var stream = new MemoryStream())
            {
                if (ShouldRotateImage(image))
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                image.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                using (var xImage = XImage.FromStream(stream))
                {
                    double xOffset;
                    if (ImageFitsPdf(image))
                    {
                        xOffset = (PdfPageWidth - xImage.PointWidth - 2 * margin) / 2;
                        gfx.DrawImage(xImage, margin + xOffset, margin);
                    }
                    else
                    {
                        double scaledWidth;
                        double scaledHeight;
                        if (xImage.PointWidth > xImage.PointHeight)
                        {
                            scaledWidth = PdfPageWidth - 2 * margin;
                            scaledHeight = scaledWidth / xImage.Size.Width * xImage.Size.Height;
                        }
                        else
                        {
                            scaledHeight = PdfPageHeight - 2 * margin;
                            scaledWidth = scaledHeight / xImage.Size.Height * xImage.Size.Width;
                        }

                        xOffset = (PdfPageWidth - scaledWidth - 2 * margin) / 2;
                        gfx.DrawImage(xImage, margin + xOffset, margin, scaledWidth, scaledHeight);
                    }
                }
            }
        }

        private static bool ShouldRotateImage(Image image)
        {
            var autoRotation = ImageFitsPdf(image) is false 
                                   && Properties.Settings.Default.PdfImageOrientation == PdfImageOrientation.Auto 
                                   && image.Width > image.Height;

            return autoRotation || Properties.Settings.Default.PdfImageOrientation == PdfImageOrientation.Vertical;
        }

        private static bool ImageFitsPdf(Image image)
        {
            var maxWidth = PdfPageWidth - 2 * Properties.Settings.Default.PdfMargin;
            var maxHeight = PdfPageHeight - 2 * Properties.Settings.Default.PdfMargin;
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
