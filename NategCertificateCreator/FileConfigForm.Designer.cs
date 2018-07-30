namespace NategCertificateCreator
{
    partial class FileConfigForm
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
            this.ConfigurationBox = new System.Windows.Forms.GroupBox();
            this.HeaderCheck = new System.Windows.Forms.CheckBox();
            this.SpaceRadio = new System.Windows.Forms.RadioButton();
            this.TabRadio = new System.Windows.Forms.RadioButton();
            this.SemiColonRadio = new System.Windows.Forms.RadioButton();
            this.CommaRadio = new System.Windows.Forms.RadioButton();
            this.DelimiterLabel = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfigurationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigurationBox
            // 
            this.ConfigurationBox.Controls.Add(this.HeaderCheck);
            this.ConfigurationBox.Controls.Add(this.SpaceRadio);
            this.ConfigurationBox.Controls.Add(this.TabRadio);
            this.ConfigurationBox.Controls.Add(this.SemiColonRadio);
            this.ConfigurationBox.Controls.Add(this.CommaRadio);
            this.ConfigurationBox.Controls.Add(this.DelimiterLabel);
            this.ConfigurationBox.Location = new System.Drawing.Point(12, 12);
            this.ConfigurationBox.Name = "ConfigurationBox";
            this.ConfigurationBox.Size = new System.Drawing.Size(346, 113);
            this.ConfigurationBox.TabIndex = 0;
            this.ConfigurationBox.TabStop = false;
            this.ConfigurationBox.Text = "Configuration";
            // 
            // HeaderCheck
            // 
            this.HeaderCheck.AutoSize = true;
            this.HeaderCheck.Location = new System.Drawing.Point(26, 77);
            this.HeaderCheck.Name = "HeaderCheck";
            this.HeaderCheck.Size = new System.Drawing.Size(80, 17);
            this.HeaderCheck.TabIndex = 5;
            this.HeaderCheck.Text = "File Header";
            this.HeaderCheck.UseVisualStyleBackColor = true;
            // 
            // SpaceRadio
            // 
            this.SpaceRadio.AutoSize = true;
            this.SpaceRadio.Location = new System.Drawing.Point(266, 43);
            this.SpaceRadio.Name = "SpaceRadio";
            this.SpaceRadio.Size = new System.Drawing.Size(56, 17);
            this.SpaceRadio.TabIndex = 4;
            this.SpaceRadio.TabStop = true;
            this.SpaceRadio.Text = "Space";
            this.SpaceRadio.UseVisualStyleBackColor = true;
            // 
            // TabRadio
            // 
            this.TabRadio.AutoSize = true;
            this.TabRadio.Location = new System.Drawing.Point(201, 43);
            this.TabRadio.Name = "TabRadio";
            this.TabRadio.Size = new System.Drawing.Size(44, 17);
            this.TabRadio.TabIndex = 3;
            this.TabRadio.TabStop = true;
            this.TabRadio.Text = "Tab";
            this.TabRadio.UseVisualStyleBackColor = true;
            // 
            // SemiColonRadio
            // 
            this.SemiColonRadio.AutoSize = true;
            this.SemiColonRadio.Location = new System.Drawing.Point(109, 43);
            this.SemiColonRadio.Name = "SemiColonRadio";
            this.SemiColonRadio.Size = new System.Drawing.Size(78, 17);
            this.SemiColonRadio.TabIndex = 2;
            this.SemiColonRadio.TabStop = true;
            this.SemiColonRadio.Text = "Semi Colon";
            this.SemiColonRadio.UseVisualStyleBackColor = true;
            // 
            // CommaRadio
            // 
            this.CommaRadio.AutoSize = true;
            this.CommaRadio.Location = new System.Drawing.Point(40, 43);
            this.CommaRadio.Name = "CommaRadio";
            this.CommaRadio.Size = new System.Drawing.Size(59, 17);
            this.CommaRadio.TabIndex = 1;
            this.CommaRadio.TabStop = true;
            this.CommaRadio.Text = "comma";
            this.CommaRadio.UseVisualStyleBackColor = true;
            // 
            // DelimiterLabel
            // 
            this.DelimiterLabel.AutoSize = true;
            this.DelimiterLabel.Location = new System.Drawing.Point(23, 27);
            this.DelimiterLabel.Name = "DelimiterLabel";
            this.DelimiterLabel.Size = new System.Drawing.Size(50, 13);
            this.DelimiterLabel.TabIndex = 0;
            this.DelimiterLabel.Text = "Delimiter:";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(202, 140);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(283, 140);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FileConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 175);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.ConfigurationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FileConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Csv File Configuration";
            this.Load += new System.EventHandler(this.FileConfigForm_Load);
            this.ConfigurationBox.ResumeLayout(false);
            this.ConfigurationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigurationBox;
        private System.Windows.Forms.CheckBox HeaderCheck;
        private System.Windows.Forms.RadioButton SpaceRadio;
        private System.Windows.Forms.RadioButton TabRadio;
        private System.Windows.Forms.RadioButton SemiColonRadio;
        private System.Windows.Forms.RadioButton CommaRadio;
        private System.Windows.Forms.Label DelimiterLabel;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}