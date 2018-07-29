namespace NategCertificateCreator
{
    partial class PoliceConfigurationForm
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
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontType = new System.Windows.Forms.ComboBox();
            this.FontColor = new System.Windows.Forms.ComboBox();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.FontColorLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.SampleText = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.FontBox = new System.Windows.Forms.GroupBox();
            this.SampleBox = new System.Windows.Forms.GroupBox();
            this.FontBox.SuspendLayout();
            this.SampleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Location = new System.Drawing.Point(46, 28);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(31, 13);
            this.FontLabel.TabIndex = 0;
            this.FontLabel.Text = "Font:";
            // 
            // FontType
            // 
            this.FontType.FormattingEnabled = true;
            this.FontType.Location = new System.Drawing.Point(103, 25);
            this.FontType.Name = "FontType";
            this.FontType.Size = new System.Drawing.Size(215, 21);
            this.FontType.TabIndex = 1;
            this.FontType.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // FontColor
            // 
            this.FontColor.FormattingEnabled = true;
            this.FontColor.Location = new System.Drawing.Point(103, 71);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(215, 21);
            this.FontColor.TabIndex = 2;
            this.FontColor.SelectedIndexChanged += new System.EventHandler(this.FontColor_SelectedIndexChanged);
            // 
            // FontSize
            // 
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Location = new System.Drawing.Point(103, 121);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(215, 21);
            this.FontSize.TabIndex = 3;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // FontColorLabel
            // 
            this.FontColorLabel.AutoSize = true;
            this.FontColorLabel.Location = new System.Drawing.Point(19, 74);
            this.FontColorLabel.Name = "FontColorLabel";
            this.FontColorLabel.Size = new System.Drawing.Size(58, 13);
            this.FontColorLabel.TabIndex = 4;
            this.FontColorLabel.Text = "Font Color:";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(23, 129);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(54, 13);
            this.FontSizeLabel.TabIndex = 5;
            this.FontSizeLabel.Text = "Font Size:";
            // 
            // SampleText
            // 
            this.SampleText.AutoSize = true;
            this.SampleText.Location = new System.Drawing.Point(34, 42);
            this.SampleText.Name = "SampleText";
            this.SampleText.Size = new System.Drawing.Size(66, 13);
            this.SampleText.TabIndex = 6;
            this.SampleText.Text = "Sample Text";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(283, 287);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(202, 287);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // FontBox
            // 
            this.FontBox.Controls.Add(this.FontType);
            this.FontBox.Controls.Add(this.FontLabel);
            this.FontBox.Controls.Add(this.FontColor);
            this.FontBox.Controls.Add(this.FontSize);
            this.FontBox.Controls.Add(this.FontSizeLabel);
            this.FontBox.Controls.Add(this.FontColorLabel);
            this.FontBox.Location = new System.Drawing.Point(12, 12);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(346, 169);
            this.FontBox.TabIndex = 9;
            this.FontBox.TabStop = false;
            this.FontBox.Text = "Font";
            // 
            // SampleBox
            // 
            this.SampleBox.Controls.Add(this.SampleText);
            this.SampleBox.Location = new System.Drawing.Point(12, 187);
            this.SampleBox.Name = "SampleBox";
            this.SampleBox.Size = new System.Drawing.Size(346, 94);
            this.SampleBox.TabIndex = 10;
            this.SampleBox.TabStop = false;
            this.SampleBox.Text = "Sample";
            // 
            // PoliceConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 322);
            this.Controls.Add(this.SampleBox);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PoliceConfigurationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Police Configuration";
            this.FontBox.ResumeLayout(false);
            this.FontBox.PerformLayout();
            this.SampleBox.ResumeLayout(false);
            this.SampleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.ComboBox FontType;
        private System.Windows.Forms.ComboBox FontColor;
        private System.Windows.Forms.ComboBox FontSize;
        private System.Windows.Forms.Label FontColorLabel;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.Label SampleText;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox FontBox;
        private System.Windows.Forms.GroupBox SampleBox;
    }
}