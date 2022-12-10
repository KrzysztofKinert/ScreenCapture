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
    internal static class SaveFile
    {
        public static void SaveToImage(Image capturedImage)
        {
            ImageFormat format = Properties.Settings.Default.ImageFormat;
            string fileName = GetFileName(Properties.Settings.Default.ImageFormat.ToString());

            if (fileName != null)
                capturedImage.Save(fileName, format);
        }

        public static void SaveToPDF(Image capturedImage)
        {
            var document = new PdfDocument();
            var page = document.AddPage();

            using(var gfx = XGraphics.FromPdfPage(page))
            using(var stream = new MemoryStream())
            {
                capturedImage.Save(stream, ImageFormat.Bmp);
                stream.Position = 0;
                using (var image = XImage.FromStream(stream))
                {
                    if (image.Size.Width > 580)
                    {
                        var height = 580 / image.Size.Width * image.Size.Height;
                        gfx.DrawImage(image, 5, 5, 585, height);
                    }
                    else
                        gfx.DrawImage(image, 5, 5);

                    var fileName = GetFileName("PDF");
                    if (fileName != null)
                        document.Save(fileName);
                }
            }
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
