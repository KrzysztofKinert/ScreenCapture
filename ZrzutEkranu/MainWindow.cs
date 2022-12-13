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

            var localizedScreenSnippingNames = new List<string>() { "Screen Snipping", "" };
            var a = ContainsSnippingTool(e);
            if (localizedScreenSnippingNames.Contains(e.SourceApplication.Title) && e.SourceApplication.Title != "Snipping Tool")
            {
                if (Properties.Settings.Default.ClipboardSource_Other is false)
                    return;
            }
            else switch (e.SourceApplication.Title)
            {
                case "Screen Snipping" when Properties.Settings.Default.ClipboardSource_ZrzutEkranu is false:
                case "Snipping Tool" when Properties.Settings.Default.ClipboardSource_SnippingTool is false:
                    return;
            }

            _capturedImage = _clipboard.ClipboardImage;
            ScreenCaptureImage.Image = _capturedImage;


            //if (e.SourceApplication.Title == "Screen Snipping" || e.SourceApplication.Title == "Snipping Tool")
            //{
            //    switch (e.SourceApplication.Title)
            //    {
            //        case "Screen Snipping" when Properties.Settings.Default.ClipboardSource_ZrzutEkranu:
            //            _capturedImage = _clipboard.ClipboardImage;
            //            ScreenCaptureImage.Image = _capturedImage;
            //            break;
            //        case "Snipping Tool" when Properties.Settings.Default.ClipboardSource_SnippingTool:
            //            _capturedImage = _clipboard.ClipboardImage;
            //            ScreenCaptureImage.Image = _capturedImage;
            //            break;
            //    }
            //}
            //else if (Properties.Settings.Default.ClipboardSource_Other)
            //{
            //    _capturedImage = _clipboard.ClipboardImage;
            //    ScreenCaptureImage.Image = _capturedImage;
            //}


            //if (e.SourceApplication.Title == "Screen Snipping" && Properties.Settings.Default.ClipboardSource_ZrzutEkranu)
            //{
            //    _capturedImage = _clipboard.ClipboardImage;
            //    ScreenCaptureImage.Image = _capturedImage;
            //}

            //if (e.SourceApplication.Title == "Snipping Tool" &&
            //    Properties.Settings.Default.ClipboardSource_SnippingTool)
            //{
            //    _capturedImage = _clipboard.ClipboardImage;
            //    ScreenCaptureImage.Image = _capturedImage;
            //}

            //if (Properties.Settings.Default.ClipboardSource_Other)
            //{
            //    _capturedImage = _clipboard.ClipboardImage;
            //    ScreenCaptureImage.Image = _capturedImage;
            //}

            SetImageSizeMode();
        }


        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            SetImageSizeMode();
        }

        private bool ContainsSnippingTool(SharpClipboard.ClipboardChangedEventArgs e)
        {
            ResourceManager myRes = new ResourceManager(typeof(string));
            ResourceSet resSet = myRes.GetResourceSet(CultureInfo.CurrentCulture, true, true);

            var lol = Resources.ScreenSnippingLocalization.
            var lmao = "a";
            return true;
        }
        private void SetImageSizeMode()
        {
            if (_capturedImage is null)
                return;

            if (ScreenCaptureBox.Size.Width > _capturedImage.Width &&
                ScreenCaptureBox.Size.Height > _capturedImage.Height)
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

            SaveFile.SaveToPDF(_capturedImage);
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
