namespace ZrzutEkranu
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Screenshot_Button = new System.Windows.Forms.Button();
            this.SaveToImage_Button = new System.Windows.Forms.Button();
            this.SaveToPDF_Button = new System.Windows.Forms.Button();
            this.Screenshot_GroupBox = new System.Windows.Forms.GroupBox();
            this.Screenshot_PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenSettings_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Screenshot_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screenshot_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.Screenshot_Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveToImage_Button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveToPDF_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Screenshot_GroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenSettings_Button, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 529);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Screenshot_Button
            // 
            this.Screenshot_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screenshot_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screenshot_Button.Image = global::ZrzutEkranu.Properties.Resources.screenshot;
            this.Screenshot_Button.Location = new System.Drawing.Point(6, 6);
            this.Screenshot_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Screenshot_Button.Name = "Screenshot_Button";
            this.Screenshot_Button.Size = new System.Drawing.Size(188, 68);
            this.Screenshot_Button.TabIndex = 5;
            this.Screenshot_Button.Text = "Nowy zrzut ekranu";
            this.Screenshot_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Screenshot_Button.UseVisualStyleBackColor = true;
            this.Screenshot_Button.Click += new System.EventHandler(this.CaptureScreen_Button_Click);
            // 
            // SaveToImage_Button
            // 
            this.SaveToImage_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveToImage_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToImage_Button.Image = global::ZrzutEkranu.Properties.Resources.image;
            this.SaveToImage_Button.Location = new System.Drawing.Point(406, 6);
            this.SaveToImage_Button.Margin = new System.Windows.Forms.Padding(6);
            this.SaveToImage_Button.Name = "SaveToImage_Button";
            this.SaveToImage_Button.Size = new System.Drawing.Size(188, 68);
            this.SaveToImage_Button.TabIndex = 7;
            this.SaveToImage_Button.Text = "Zapisz do obrazu";
            this.SaveToImage_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveToImage_Button.UseVisualStyleBackColor = true;
            this.SaveToImage_Button.Click += new System.EventHandler(this.SaveToImage_Button_Click);
            // 
            // SaveToPDF_Button
            // 
            this.SaveToPDF_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveToPDF_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToPDF_Button.Image = global::ZrzutEkranu.Properties.Resources.pdf;
            this.SaveToPDF_Button.Location = new System.Drawing.Point(206, 6);
            this.SaveToPDF_Button.Margin = new System.Windows.Forms.Padding(6);
            this.SaveToPDF_Button.Name = "SaveToPDF_Button";
            this.SaveToPDF_Button.Size = new System.Drawing.Size(188, 68);
            this.SaveToPDF_Button.TabIndex = 6;
            this.SaveToPDF_Button.Text = "Zapisz do PDF";
            this.SaveToPDF_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveToPDF_Button.UseVisualStyleBackColor = true;
            this.SaveToPDF_Button.Click += new System.EventHandler(this.SaveToPDF_Button_Click);
            // 
            // Screenshot_GroupBox
            // 
            this.Screenshot_GroupBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Screenshot_GroupBox, 5);
            this.Screenshot_GroupBox.Controls.Add(this.Screenshot_PictureBox);
            this.Screenshot_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screenshot_GroupBox.Location = new System.Drawing.Point(3, 83);
            this.Screenshot_GroupBox.Name = "Screenshot_GroupBox";
            this.Screenshot_GroupBox.Size = new System.Drawing.Size(768, 443);
            this.Screenshot_GroupBox.TabIndex = 8;
            this.Screenshot_GroupBox.TabStop = false;
            this.Screenshot_GroupBox.Text = "Zrzut ekranu";
            // 
            // Screenshot_PictureBox
            // 
            this.Screenshot_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screenshot_PictureBox.Location = new System.Drawing.Point(3, 31);
            this.Screenshot_PictureBox.Name = "Screenshot_PictureBox";
            this.Screenshot_PictureBox.Size = new System.Drawing.Size(762, 409);
            this.Screenshot_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Screenshot_PictureBox.TabIndex = 0;
            this.Screenshot_PictureBox.TabStop = false;
            // 
            // OpenSettings_Button
            // 
            this.OpenSettings_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSettings_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSettings_Button.Image = global::ZrzutEkranu.Properties.Resources.settings;
            this.OpenSettings_Button.Location = new System.Drawing.Point(700, 6);
            this.OpenSettings_Button.Margin = new System.Windows.Forms.Padding(6);
            this.OpenSettings_Button.Name = "OpenSettings_Button";
            this.OpenSettings_Button.Size = new System.Drawing.Size(68, 68);
            this.OpenSettings_Button.TabIndex = 1;
            this.OpenSettings_Button.UseVisualStyleBackColor = true;
            this.OpenSettings_Button.Click += new System.EventHandler(this.OpenSettings_Button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "MainWindow";
            this.Text = "ZrzutEkranu";
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Screenshot_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Screenshot_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSettings_Button;
        private System.Windows.Forms.Button Screenshot_Button;
        private System.Windows.Forms.Button SaveToPDF_Button;
        private System.Windows.Forms.Button SaveToImage_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Screenshot_GroupBox;
        private System.Windows.Forms.PictureBox Screenshot_PictureBox;
    }
}

