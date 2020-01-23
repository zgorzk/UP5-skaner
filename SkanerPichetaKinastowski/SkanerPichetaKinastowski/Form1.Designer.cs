namespace SkanerPichetaKinastowski
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.scannedImageBox = new System.Windows.Forms.PictureBox();
            this.dpiLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.dpiTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.colorModeComboBox = new System.Windows.Forms.ComboBox();
            this.colorModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scannedImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(19, 47);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(151, 24);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect to scanner";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(25, 19);
            this.connectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(78, 13);
            this.connectedLabel.TabIndex = 1;
            this.connectedLabel.Text = "Not connected";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(23, 101);
            this.scanButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(147, 67);
            this.scanButton.TabIndex = 2;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // scannedImageBox
            // 
            this.scannedImageBox.Location = new System.Drawing.Point(355, 19);
            this.scannedImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scannedImageBox.Name = "scannedImageBox";
            this.scannedImageBox.Size = new System.Drawing.Size(518, 623);
            this.scannedImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scannedImageBox.TabIndex = 3;
            this.scannedImageBox.TabStop = false;
            this.scannedImageBox.Click += new System.EventHandler(this.scannedImageBox_Click);
            // 
            // dpiLabel
            // 
            this.dpiLabel.AutoSize = true;
            this.dpiLabel.Location = new System.Drawing.Point(26, 192);
            this.dpiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dpiLabel.Name = "dpiLabel";
            this.dpiLabel.Size = new System.Drawing.Size(31, 13);
            this.dpiLabel.TabIndex = 4;
            this.dpiLabel.Text = "DPI: ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(26, 223);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(26, 258);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            // 
            // dpiTextBox
            // 
            this.dpiTextBox.Location = new System.Drawing.Point(95, 190);
            this.dpiTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpiTextBox.Name = "dpiTextBox";
            this.dpiTextBox.Size = new System.Drawing.Size(68, 20);
            this.dpiTextBox.TabIndex = 7;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(95, 221);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(68, 20);
            this.heightTextBox.TabIndex = 8;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(95, 258);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(68, 20);
            this.WidthTextBox.TabIndex = 9;
            // 
            // colorModeComboBox
            // 
            this.colorModeComboBox.FormattingEnabled = true;
            this.colorModeComboBox.Items.AddRange(new object[] {
            "Grayscale",
            "Color"});
            this.colorModeComboBox.Location = new System.Drawing.Point(89, 293);
            this.colorModeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorModeComboBox.Name = "colorModeComboBox";
            this.colorModeComboBox.Size = new System.Drawing.Size(82, 21);
            this.colorModeComboBox.TabIndex = 10;
            // 
            // colorModeLabel
            // 
            this.colorModeLabel.AutoSize = true;
            this.colorModeLabel.Location = new System.Drawing.Point(26, 295);
            this.colorModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorModeLabel.Name = "colorModeLabel";
            this.colorModeLabel.Size = new System.Drawing.Size(63, 13);
            this.colorModeLabel.TabIndex = 11;
            this.colorModeLabel.Text = "Color mode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 690);
            this.Controls.Add(this.colorModeLabel);
            this.Controls.Add(this.colorModeComboBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.dpiTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.dpiLabel);
            this.Controls.Add(this.scannedImageBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.connectButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scannedImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.PictureBox scannedImageBox;
        private System.Windows.Forms.Label dpiLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox dpiTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.ComboBox colorModeComboBox;
        private System.Windows.Forms.Label colorModeLabel;
    }
}

