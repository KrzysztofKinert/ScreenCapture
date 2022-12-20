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
        private Image _screenshot;

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

            _screenshot = _clipboard.ClipboardImage;
            Screenshot_PictureBox.Image = _screenshot;
            SetPictureBoxSizeMode();
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            SetPictureBoxSizeMode();
        }

        private void SetPictureBoxSizeMode()
        {
            if (_screenshot is null)
                return;

            if (Screenshot_GroupBox.Size.Width > _screenshot.Width && Screenshot_GroupBox.Size.Height > _screenshot.Height)
                Screenshot_PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                Screenshot_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
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
                MessageBox.Show(exception.Message, "Błąd procesu zrzutu ekranu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToPDF_Button_Click(object sender, EventArgs e)
        {
            if (_screenshot is null)
                return;

            try
            {
                SaveScreenshot.AsPdf((Image)_screenshot.Clone());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Błąd zapisu zrzutu do PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToImage_Button_Click(object sender, EventArgs e)
        {
            if (_screenshot is null)
                return;

            try
            {
                SaveScreenshot.AsImage(_screenshot);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Błąd zapisu zrzutu do obrazu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}