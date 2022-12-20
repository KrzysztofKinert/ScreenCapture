namespace ZrzutEkranu
{
    partial class SettingsWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Other_Checkbox = new System.Windows.Forms.CheckBox();
            this.SnippingTool_Checkbox = new System.Windows.Forms.CheckBox();
            this.ZrzutEkranu_Checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BMP_RadioButton = new System.Windows.Forms.RadioButton();
            this.JPG_RadioButton = new System.Windows.Forms.RadioButton();
            this.PNG_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Margin_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Auto_RadioButton = new System.Windows.Forms.RadioButton();
            this.Vertical_RadioButton = new System.Windows.Forms.RadioButton();
            this.Horizontal_RadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_NumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.Other_Checkbox);
            this.groupBox1.Controls.Add(this.SnippingTool_Checkbox);
            this.groupBox1.Controls.Add(this.ZrzutEkranu_Checkbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akceptowane źródła zrzutu ekranu";
            // 
            // Other_Checkbox
            // 
            this.Other_Checkbox.AutoSize = true;
            this.Other_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other_Checkbox.Location = new System.Drawing.Point(552, 40);
            this.Other_Checkbox.Name = "Other_Checkbox";
            this.Other_Checkbox.Size = new System.Drawing.Size(99, 35);
            this.Other_Checkbox.TabIndex = 2;
            this.Other_Checkbox.Text = "Inne";
            this.Other_Checkbox.UseVisualStyleBackColor = true;
            this.Other_Checkbox.CheckedChanged += new System.EventHandler(this.Other_Checkbox_CheckedChanged);
            // 
            // SnippingTool_Checkbox
            // 
            this.SnippingTool_Checkbox.AutoSize = true;
            this.SnippingTool_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnippingTool_Checkbox.Location = new System.Drawing.Point(225, 40);
            this.SnippingTool_Checkbox.Name = "SnippingTool_Checkbox";
            this.SnippingTool_Checkbox.Size = new System.Drawing.Size(301, 35);
            this.SnippingTool_Checkbox.TabIndex = 1;
            this.SnippingTool_Checkbox.Text = "Narzędzie Wycinania";
            this.SnippingTool_Checkbox.UseVisualStyleBackColor = true;
            this.SnippingTool_Checkbox.CheckedChanged += new System.EventHandler(this.SnippingTool_Checkbox_CheckedChanged);
            // 
            // ZrzutEkranu_Checkbox
            // 
            this.ZrzutEkranu_Checkbox.AutoSize = true;
            this.ZrzutEkranu_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZrzutEkranu_Checkbox.Location = new System.Drawing.Point(15, 40);
            this.ZrzutEkranu_Checkbox.Name = "ZrzutEkranu_Checkbox";
            this.ZrzutEkranu_Checkbox.Size = new System.Drawing.Size(195, 35);
            this.ZrzutEkranu_Checkbox.TabIndex = 0;
            this.ZrzutEkranu_Checkbox.Text = "ZrzutEkranu";
            this.ZrzutEkranu_Checkbox.UseVisualStyleBackColor = true;
            this.ZrzutEkranu_Checkbox.CheckedChanged += new System.EventHandler(this.ZrzutEkranu_Checkbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.BMP_RadioButton);
            this.groupBox2.Controls.Add(this.JPG_RadioButton);
            this.groupBox2.Controls.Add(this.PNG_RadioButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format zapisywanego obrazu";
            // 
            // BMP_RadioButton
            // 
            this.BMP_RadioButton.AutoSize = true;
            this.BMP_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMP_RadioButton.Location = new System.Drawing.Point(460, 40);
            this.BMP_RadioButton.Name = "BMP_RadioButton";
            this.BMP_RadioButton.Size = new System.Drawing.Size(103, 35);
            this.BMP_RadioButton.TabIndex = 2;
            this.BMP_RadioButton.Text = "BMP";
            this.BMP_RadioButton.UseVisualStyleBackColor = true;
            this.BMP_RadioButton.CheckedChanged += new System.EventHandler(this.SetFormatSetting);
            // 
            // JPG_RadioButton
            // 
            this.JPG_RadioButton.AutoSize = true;
            this.JPG_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPG_RadioButton.Location = new System.Drawing.Point(280, 40);
            this.JPG_RadioButton.Name = "JPG_RadioButton";
            this.JPG_RadioButton.Size = new System.Drawing.Size(98, 35);
            this.JPG_RadioButton.TabIndex = 1;
            this.JPG_RadioButton.Text = "JPG";
            this.JPG_RadioButton.UseVisualStyleBackColor = true;
            this.JPG_RadioButton.CheckedChanged += new System.EventHandler(this.SetFormatSetting);
            // 
            // PNG_RadioButton
            // 
            this.PNG_RadioButton.AutoSize = true;
            this.PNG_RadioButton.Checked = true;
            this.PNG_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNG_RadioButton.Location = new System.Drawing.Point(100, 40);
            this.PNG_RadioButton.Name = "PNG_RadioButton";
            this.PNG_RadioButton.Size = new System.Drawing.Size(104, 35);
            this.PNG_RadioButton.TabIndex = 0;
            this.PNG_RadioButton.TabStop = true;
            this.PNG_RadioButton.Text = "PNG";
            this.PNG_RadioButton.UseVisualStyleBackColor = true;
            this.PNG_RadioButton.CheckedChanged += new System.EventHandler(this.SetFormatSetting);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Margin_NumericUpDown);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Margines obrazu w PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "pikseli";
            // 
            // Margin_NumericUpDown
            // 
            this.Margin_NumericUpDown.AutoSize = true;
            this.Margin_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin_NumericUpDown.Location = new System.Drawing.Point(197, 37);
            this.Margin_NumericUpDown.Maximum = new decimal(new int[] {
            290,
            0,
            0,
            0});
            this.Margin_NumericUpDown.Name = "Margin_NumericUpDown";
            this.Margin_NumericUpDown.Size = new System.Drawing.Size(200, 38);
            this.Margin_NumericUpDown.TabIndex = 0;
            this.Margin_NumericUpDown.ValueChanged += new System.EventHandler(this.Margin_NumericUpDown_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.Auto_RadioButton);
            this.groupBox4.Controls.Add(this.Vertical_RadioButton);
            this.groupBox4.Controls.Add(this.Horizontal_RadioButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(668, 91);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orientacja obrazu w PDF";
            // 
            // Auto_RadioButton
            // 
            this.Auto_RadioButton.AutoSize = true;
            this.Auto_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto_RadioButton.Location = new System.Drawing.Point(433, 40);
            this.Auto_RadioButton.Name = "Auto_RadioButton";
            this.Auto_RadioButton.Size = new System.Drawing.Size(218, 35);
            this.Auto_RadioButton.TabIndex = 4;
            this.Auto_RadioButton.Text = "Automatyczna";
            this.Auto_RadioButton.UseVisualStyleBackColor = true;
            this.Auto_RadioButton.CheckedChanged += new System.EventHandler(this.SetPdfOrientationSetting);
            // 
            // Vertical_RadioButton
            // 
            this.Vertical_RadioButton.AutoSize = true;
            this.Vertical_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vertical_RadioButton.Location = new System.Drawing.Point(248, 40);
            this.Vertical_RadioButton.Name = "Vertical_RadioButton";
            this.Vertical_RadioButton.Size = new System.Drawing.Size(149, 35);
            this.Vertical_RadioButton.TabIndex = 3;
            this.Vertical_RadioButton.Text = "Pionowa";
            this.Vertical_RadioButton.UseVisualStyleBackColor = true;
            this.Vertical_RadioButton.CheckedChanged += new System.EventHandler(this.SetPdfOrientationSetting);
            // 
            // Horizontal_RadioButton
            // 
            this.Horizontal_RadioButton.AutoSize = true;
            this.Horizontal_RadioButton.Checked = true;
            this.Horizontal_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horizontal_RadioButton.Location = new System.Drawing.Point(60, 40);
            this.Horizontal_RadioButton.Name = "Horizontal_RadioButton";
            this.Horizontal_RadioButton.Size = new System.Drawing.Size(150, 35);
            this.Horizontal_RadioButton.TabIndex = 3;
            this.Horizontal_RadioButton.TabStop = true;
            this.Horizontal_RadioButton.Text = "Pozioma";
            this.Horizontal_RadioButton.UseVisualStyleBackColor = true;
            this.Horizontal_RadioButton.CheckedChanged += new System.EventHandler(this.SetPdfOrientationSetting);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 379);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "SettingsWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Margin_NumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BMP_RadioButton;
        private System.Windows.Forms.RadioButton JPG_RadioButton;
        private System.Windows.Forms.RadioButton PNG_RadioButton;
        private System.Windows.Forms.CheckBox Other_Checkbox;
        private System.Windows.Forms.CheckBox SnippingTool_Checkbox;
        private System.Windows.Forms.CheckBox ZrzutEkranu_Checkbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Margin_NumericUpDown;
        private System.Windows.Forms.RadioButton Auto_RadioButton;
        private System.Windows.Forms.RadioButton Vertical_RadioButton;
        private System.Windows.Forms.RadioButton Horizontal_RadioButton;
    }
}