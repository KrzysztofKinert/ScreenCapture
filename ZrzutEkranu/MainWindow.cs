using System;
using System.Drawing;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;
using ZrzutEkranu.Properties;
using ZrzutEkranu.Utility;

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
                    if (Settings.Default.ClipboardSource_ZrzutEkranu is false)
                        return;
                    break;
                case "Snipping Tool":
                case "Narzedzie Wycinanie":
                    if (Settings.Default.ClipboardSource_SnippingTool is false)
                        return;
                    break;
                default:
                    if (Settings.Default.ClipboardSource_Other is false)
                        return;
                    break;
            }

            _capturedImage = _clipboard.ClipboardImage;
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

            if (ScreenCaptureBox.Size.Width > _capturedImage.Width && ScreenCaptureBox.Size.Height > _capturedImage.Height)
                ScreenCaptureImage.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                ScreenCaptureImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void OpenSettings_Button_Click(object sender, EventArgs e)
        {
            var settings = new SettingsWindow();
            settings.ShowDialog();
        }

        private void CaptureScreen_Button_Click(object sender, EventArgs e)
        {
            try
            {
                StartProcess.Screenclip();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Błąd procesu zrzutu ekranu", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveToPDF_Button_Click(object sender, EventArgs e)
        {
            if (_capturedImage is null)
                return;

            try
            {
                SaveFile.SaveToPdf((Image)_capturedImage.Clone());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Błąd zapisu do PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToImageButton_Click(object sender, EventArgs e)
        {
            if (_capturedImage is null)
                return;

            try
            {
                SaveFile.SaveToImage(_capturedImage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Błąd zapisu do obrazu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}