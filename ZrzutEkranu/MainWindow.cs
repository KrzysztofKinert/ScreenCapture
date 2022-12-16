using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using WK.Libraries.SharpClipboardNS;
using ZrzutEkranu.Utils;


namespace ZrzutEkranu
{
    public partial class MainWindow : Form
    {
        private readonly SharpClipboard _clipboard = new SharpClipboard();
        private Image _capturedImage;

        public MainWindow()
        {
            
            InitializeComponent();
            _clipboard.ClipboardChanged += ClipboardChanged;
        }


        private void ClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            if (e.ContentType != SharpClipboard.ContentTypes.Image) 
                return;

            switch (e.SourceApplication.Title)
            {
                case "Screen Snipping":
                case "Wycinanie ekranu":
                    if (Properties.Settings.Default.ClipboardSource_ZrzutEkranu is false)
                        return;
                    break;
                case "Snipping Tool":
                case "Narzedzie Wycinanie":
                    if (Properties.Settings.Default.ClipboardSource_SnippingTool is false)
                        return;
                    break;
                default:
                    if (Properties.Settings.Default.ClipboardSource_Other is false)
                        return;
                    break;
            }

            _capturedImage = _clipboard.ClipboardImage;
            ////_capturedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //var bitmap = new Bitmap(_capturedImage);

            //ScaleBitmapLogicalToDevice(ref bitmap);
            //_capturedImage = bitmap;

            ScreenCaptureImage.Image = _capturedImage;
            SetImageSizeMode();
        }


        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            SetImageSizeMode();
        }

        private void SetImageSizeMode()
        {
            if (_capturedImage is null)
                return;

            if (ScreenCaptureBox.Size.Width > _capturedImage.Width 
                && ScreenCaptureBox.Size.Height > _capturedImage.Height)
            {
                ScreenCaptureImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                ScreenCaptureImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void OpenSettings_Button_Click(object sender, EventArgs e)
        {
            var settings = new SettingsWindow();
            settings.ShowDialog();
        }

        private void CaptureScreen_Button_Click(object sender, EventArgs e)
        {
            StartProcess.Screenclip();
        }

        private void SaveToPDF_Button_Click(object sender, EventArgs e)
        {
            if (_capturedImage is null)
                return;

            SaveFile.SaveToPdf((Image)_capturedImage.Clone());
        }

        private void SaveToImageButton_Click(object sender, EventArgs e)
        {
            if (_capturedImage is null)
                return;

            SaveFile.SaveToImage(_capturedImage);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
