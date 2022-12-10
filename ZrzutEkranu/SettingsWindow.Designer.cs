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
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.47221F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.52779F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Other_Checkbox);
            this.groupBox1.Controls.Add(this.SnippingTool_Checkbox);
            this.groupBox1.Controls.Add(this.ZrzutEkranu_Checkbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akecptowane źródła zrzutu ekranu";
            // 
            // Other_Checkbox
            // 
            this.Other_Checkbox.AutoSize = true;
            this.Other_Checkbox.Location = new System.Drawing.Point(487, 34);
            this.Other_Checkbox.Name = "Other_Checkbox";
            this.Other_Checkbox.Size = new System.Drawing.Size(91, 33);
            this.Other_Checkbox.TabIndex = 2;
            this.Other_Checkbox.Text = "Inne";
            this.Other_Checkbox.UseVisualStyleBackColor = true;
            this.Other_Checkbox.CheckedChanged += new System.EventHandler(this.Other_Checkbox_CheckedChanged);
            // 
            // SnippingTool_Checkbox
            // 
            this.SnippingTool_Checkbox.AutoSize = true;
            this.SnippingTool_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnippingTool_Checkbox.Location = new System.Drawing.Point(197, 34);
            this.SnippingTool_Checkbox.Name = "SnippingTool_Checkbox";
            this.SnippingTool_Checkbox.Size = new System.Drawing.Size(269, 33);
            this.SnippingTool_Checkbox.TabIndex = 1;
            this.SnippingTool_Checkbox.Text = "Narzędzie Wycinania";
            this.SnippingTool_Checkbox.UseVisualStyleBackColor = true;
            this.SnippingTool_Checkbox.CheckedChanged += new System.EventHandler(this.SnippingTool_Checkbox_CheckedChanged);
            // 
            // ZrzutEkranu_Checkbox
            // 
            this.ZrzutEkranu_Checkbox.AutoSize = true;
            this.ZrzutEkranu_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZrzutEkranu_Checkbox.Location = new System.Drawing.Point(19, 34);
            this.ZrzutEkranu_Checkbox.Name = "ZrzutEkranu_Checkbox";
            this.ZrzutEkranu_Checkbox.Size = new System.Drawing.Size(172, 33);
            this.ZrzutEkranu_Checkbox.TabIndex = 0;
            this.ZrzutEkranu_Checkbox.Text = "ZrzutEkranu";
            this.ZrzutEkranu_Checkbox.UseVisualStyleBackColor = true;
            this.ZrzutEkranu_Checkbox.CheckedChanged += new System.EventHandler(this.ZrzutEkranu_Checkbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BMP_RadioButton);
            this.groupBox2.Controls.Add(this.JPG_RadioButton);
            this.groupBox2.Controls.Add(this.PNG_RadioButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format zapisywanego obrazu";
            // 
            // BMP_RadioButton
            // 
            this.BMP_RadioButton.AutoSize = true;
            this.BMP_RadioButton.Location = new System.Drawing.Point(482, 66);
            this.BMP_RadioButton.Name = "BMP_RadioButton";
            this.BMP_RadioButton.Size = new System.Drawing.Size(96, 33);
            this.BMP_RadioButton.TabIndex = 2;
            this.BMP_RadioButton.Text = "BMP";
            this.BMP_RadioButton.UseVisualStyleBackColor = true;
            this.BMP_RadioButton.CheckedChanged += new System.EventHandler(this.SetFormatSetting);
            // 
            // JPG_RadioButton
            // 
            this.JPG_RadioButton.AutoSize = true;
            this.JPG_RadioButton.Location = new System.Drawing.Point(254, 66);
            this.JPG_RadioButton.Name = "JPG_RadioButton";
            this.JPG_RadioButton.Size = new System.Drawing.Size(90, 33);
            this.JPG_RadioButton.TabIndex = 1;
            this.JPG_RadioButton.Text = "JPG";
            this.JPG_RadioButton.UseVisualStyleBackColor = true;
            this.JPG_RadioButton.CheckedChanged += new System.EventHandler(this.SetFormatSetting);
            // 
            // PNG_RadioButton
            // 
            this.PNG_RadioButton.AutoSize = true;
            this.PNG_RadioButton.Checked = true;
            this.PNG_RadioButton.Location = new System.Drawing.Point(19, 66);
            this.PNG_RadioButton.Name = "PNG_RadioButton";
            this.PNG_RadioButton.Size = new System.Drawing.Size(96, 33);
            this.PNG_RadioButton.TabIndex = 0;
            this.PNG_RadioButton.TabStop = true;
            this.PNG_RadioButton.Text = "PNG";
            this.PNG_RadioButton.UseVisualStyleBackColor = true;
            this.PNG_RadioButton.CheckedChanged += new System.EventHandler(this.SetFormatSetting);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}