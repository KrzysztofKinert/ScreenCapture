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
            this.OpenSettings_Button = new System.Windows.Forms.Button();
            this.CaptureScreen_Button = new System.Windows.Forms.Button();
            this.SaveToPDF_Button = new System.Windows.Forms.Button();
            this.SaveToImageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScreenCaptureBox = new System.Windows.Forms.GroupBox();
            this.ScreenCaptureImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ScreenCaptureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenCaptureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenSettings_Button
            // 
            this.OpenSettings_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSettings_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSettings_Button.Location = new System.Drawing.Point(780, 6);
            this.OpenSettings_Button.Margin = new System.Windows.Forms.Padding(6);
            this.OpenSettings_Button.Name = "OpenSettings_Button";
            this.OpenSettings_Button.Size = new System.Drawing.Size(188, 68);
            this.OpenSettings_Button.TabIndex = 1;
            this.OpenSettings_Button.Text = "Ustawienia";
            this.OpenSettings_Button.UseVisualStyleBackColor = true;
            this.OpenSettings_Button.Click += new System.EventHandler(this.OpenSettings_Button_Click);
            // 
            // CaptureScreen_Button
            // 
            this.CaptureScreen_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaptureScreen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureScreen_Button.Location = new System.Drawing.Point(6, 6);
            this.CaptureScreen_Button.Margin = new System.Windows.Forms.Padding(6);
            this.CaptureScreen_Button.Name = "CaptureScreen_Button";
            this.CaptureScreen_Button.Size = new System.Drawing.Size(188, 68);
            this.CaptureScreen_Button.TabIndex = 5;
            this.CaptureScreen_Button.Text = "Nowy zrzut ekranu";
            this.CaptureScreen_Button.UseVisualStyleBackColor = true;
            this.CaptureScreen_Button.Click += new System.EventHandler(this.CaptureScreen_Button_Click);
            // 
            // SaveToPDF_Button
            // 
            this.SaveToPDF_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveToPDF_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToPDF_Button.Location = new System.Drawing.Point(206, 6);
            this.SaveToPDF_Button.Margin = new System.Windows.Forms.Padding(6);
            this.SaveToPDF_Button.Name = "SaveToPDF_Button";
            this.SaveToPDF_Button.Size = new System.Drawing.Size(188, 68);
            this.SaveToPDF_Button.TabIndex = 6;
            this.SaveToPDF_Button.Text = "Zapisz do    PDF";
            this.SaveToPDF_Button.UseVisualStyleBackColor = true;
            this.SaveToPDF_Button.Click += new System.EventHandler(this.SaveToPDF_Button_Click);
            // 
            // SaveToImageButton
            // 
            this.SaveToImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveToImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToImageButton.Location = new System.Drawing.Point(406, 6);
            this.SaveToImageButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveToImageButton.Name = "SaveToImageButton";
            this.SaveToImageButton.Size = new System.Drawing.Size(188, 68);
            this.SaveToImageButton.TabIndex = 7;
            this.SaveToImageButton.Text = "Zapisz do obrazu";
            this.SaveToImageButton.UseVisualStyleBackColor = true;
            this.SaveToImageButton.Click += new System.EventHandler(this.SaveToImageButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.CaptureScreen_Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveToImageButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveToPDF_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ScreenCaptureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenSettings_Button, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 729);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ScreenCaptureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ScreenCaptureBox, 5);
            this.ScreenCaptureBox.Controls.Add(this.label3);
            this.ScreenCaptureBox.Controls.Add(this.label2);
            this.ScreenCaptureBox.Controls.Add(this.ScreenCaptureImage);
            this.ScreenCaptureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenCaptureBox.Location = new System.Drawing.Point(3, 83);
            this.ScreenCaptureBox.Name = "ScreenCaptureBox";
            this.ScreenCaptureBox.Size = new System.Drawing.Size(968, 643);
            this.ScreenCaptureBox.TabIndex = 8;
            this.ScreenCaptureBox.TabStop = false;
            this.ScreenCaptureBox.Text = "Zrzut ekranu";
            // 
            // ScreenCaptureImage
            // 
            this.ScreenCaptureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenCaptureImage.Location = new System.Drawing.Point(3, 27);
            this.ScreenCaptureImage.Name = "ScreenCaptureImage";
            this.ScreenCaptureImage.Size = new System.Drawing.Size(962, 613);
            this.ScreenCaptureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenCaptureImage.TabIndex = 0;
            this.ScreenCaptureImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "MainWindow";
            this.Text = "ZrzutEkranu";
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ScreenCaptureBox.ResumeLayout(false);
            this.ScreenCaptureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenCaptureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSettings_Button;
        private System.Windows.Forms.Button CaptureScreen_Button;
        private System.Windows.Forms.Button SaveToPDF_Button;
        private System.Windows.Forms.Button SaveToImageButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox ScreenCaptureBox;
        private System.Windows.Forms.PictureBox ScreenCaptureImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

