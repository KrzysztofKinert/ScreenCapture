using System.Drawing;
using System.Windows.Forms;
using PdfSharp.Pdf;
using ZrzutEkranu.Properties;

namespace ZrzutEkranu.Utility
{
    internal static class SaveScreenshot
    {
        public static void AsImage(Image image)
        {
            var format = Settings.Default.ImageFormat;
            var fileName = GetFileName(Settings.Default.ImageFormat.ToString());
            if (fileName != null)
                image.Save(fileName, format);
        }

        public static void AsPdf(Image image)
        {
            var document = new PdfDocument();
            var page = document.AddPage();

            if (Pdf.ImageRotation(image))
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            Pdf.AddImageToPage(image, page);

            var fileName = GetFileName("PDF");
            if (fileName != null)
                document.Save(fileName);
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