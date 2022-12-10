using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZrzutEkranu
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();

            if (Equals(Properties.Settings.Default.ImageFormat, ImageFormat.Png)) PNG_RadioButton.Checked = true;
            if (Equals(Properties.Settings.Default.ImageFormat, ImageFormat.Jpeg)) JPG_RadioButton.Checked = true;
            if (Equals(Properties.Settings.Default.ImageFormat, ImageFormat.Bmp)) BMP_RadioButton.Checked = true;

            if (Properties.Settings.Default.ClipboardSource_ZrzutEkranu) ZrzutEkranu_Checkbox.Checked = true;
            if (Properties.Settings.Default.ClipboardSource_SnippingTool) SnippingTool_Checkbox.Checked = true;
            if (Properties.Settings.Default.ClipboardSource_Other) Other_Checkbox.Checked = true;
        }

        private void SetFormatSetting(object sender, EventArgs e)
        {
            if (PNG_RadioButton.Checked) Properties.Settings.Default.ImageFormat = ImageFormat.Png;
            if (JPG_RadioButton.Checked) Properties.Settings.Default.ImageFormat = ImageFormat.Jpeg;
            if (BMP_RadioButton.Checked) Properties.Settings.Default.ImageFormat = ImageFormat.Bmp;
            Properties.Settings.Default.Save();
        }

        private void ZrzutEkranu_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClipboardSource_ZrzutEkranu = ZrzutEkranu_Checkbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void SnippingTool_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClipboardSource_SnippingTool = SnippingTool_Checkbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void Other_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClipboardSource_Other = Other_Checkbox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
