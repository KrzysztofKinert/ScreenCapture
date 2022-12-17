using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ZrzutEkranu.Properties;
using ZrzutEkranu.Utility;

namespace ZrzutEkranu
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            if (Settings.Default.ClipboardSource_ZrzutEkranu) 
                ZrzutEkranu_Checkbox.Checked = true;
            if (Settings.Default.ClipboardSource_SnippingTool) 
                SnippingTool_Checkbox.Checked = true;
            if (Settings.Default.ClipboardSource_Other) 
                Other_Checkbox.Checked = true;

            if (Equals(Settings.Default.ImageFormat, ImageFormat.Png)) 
                PNG_RadioButton.Checked = true;
            if (Equals(Settings.Default.ImageFormat, ImageFormat.Jpeg)) 
                JPG_RadioButton.Checked = true;
            if (Equals(Settings.Default.ImageFormat, ImageFormat.Bmp)) 
                BMP_RadioButton.Checked = true;

            Margin_NumericUpDown.Value = Settings.Default.PdfMargin;

            if (Equals(Settings.Default.PdfImageOrientation, PdfImageOrientation.Vertical)) 
                Vertical_RadioButton.Checked = true;
            if (Equals(Settings.Default.PdfImageOrientation, PdfImageOrientation.Horizontal)) 
                Horizontal_RadioButton.Checked = true;
            if (Equals(Settings.Default.PdfImageOrientation, PdfImageOrientation.Auto)) 
                Auto_RadioButton.Checked = true;
        }

        private void ZrzutEkranu_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ClipboardSource_ZrzutEkranu = ZrzutEkranu_Checkbox.Checked;
            Settings.Default.Save();
        }

        private void SnippingTool_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ClipboardSource_SnippingTool = SnippingTool_Checkbox.Checked;
            Settings.Default.Save();
        }

        private void Other_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ClipboardSource_Other = Other_Checkbox.Checked;
            Settings.Default.Save();
        }

        private void SetFormatSetting(object sender, EventArgs e)
        {
            if (PNG_RadioButton.Checked) 
                Settings.Default.ImageFormat = ImageFormat.Png;
            if (JPG_RadioButton.Checked) 
                Settings.Default.ImageFormat = ImageFormat.Jpeg;
            if (BMP_RadioButton.Checked) 
                Settings.Default.ImageFormat = ImageFormat.Bmp;
            Settings.Default.Save();
        }

        private void SetPdfOrientationSetting(object sender, EventArgs e)
        {
            if (Vertical_RadioButton.Checked) 
                Settings.Default.PdfImageOrientation = PdfImageOrientation.Vertical;
            if (Horizontal_RadioButton.Checked) 
                Settings.Default.PdfImageOrientation = PdfImageOrientation.Horizontal;
            if (Auto_RadioButton.Checked) 
                Settings.Default.PdfImageOrientation = PdfImageOrientation.Auto;
            Settings.Default.Save();
        }

        private void Margin_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.PdfMargin = (int)Margin_NumericUpDown.Value;
            Settings.Default.Save();
        }
    }
}