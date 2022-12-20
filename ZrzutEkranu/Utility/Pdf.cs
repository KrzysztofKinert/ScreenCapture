using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ZrzutEkranu.Enums;
using ZrzutEkranu.Properties;

namespace ZrzutEkranu.Utility
{

    public static class Pdf
    {
        private const int PdfPageWidth = 595;
        private const int PdfPageHeight = 842;
        private const int PdfDpi = 72;

        internal static bool ImageRotation(Image image)
        {
            var autoRotation = ImageFitsPdf(image) is false
                                   && Settings.Default.PdfImageOrientation == PdfImageOrientation.Auto
                                   && image.Width > image.Height;

            return autoRotation || Settings.Default.PdfImageOrientation == PdfImageOrientation.Vertical;
        }

        internal static void AddImageToPage(Image image, PdfPage page)
        {
            var margin = Settings.Default.PdfMargin;

            using (var gfx = XGraphics.FromPdfPage(page))
            using (var stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                using (var xImage = XImage.FromStream(stream))
                {
                    if (ImageFitsPdf(image))
                    {
                        gfx.DrawImage(xImage, margin + CenterOffset(xImage.PointWidth), margin);
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
                        gfx.DrawImage(xImage, margin + CenterOffset(scaledWidth), margin, scaledWidth, scaledHeight);
                    }
                }
            }
        }

        private static double CenterOffset(double imageWidth) =>
            (PdfPageWidth - imageWidth - 2 * Settings.Default.PdfMargin) / 2;

        private static bool ImageFitsPdf(Image image)
        {
            var maxWidth = PdfPageWidth - 2 * Settings.Default.PdfMargin;
            var maxHeight = PdfPageHeight - 2 * Settings.Default.PdfMargin;
            var dpiWidth = image.Width * PdfDpi / image.HorizontalResolution;
            var dpiHeight = image.Height * PdfDpi / image.VerticalResolution;
            return dpiWidth < maxWidth && dpiHeight < maxHeight;
        }
    }
}