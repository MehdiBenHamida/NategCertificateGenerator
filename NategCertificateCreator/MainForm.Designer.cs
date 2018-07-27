namespace NategCertificateCreator
{
    partial class MainForm
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
            this.ProgressBox = new System.Windows.Forms.GroupBox();
            this.ProgressText = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreationProgress = new System.Windows.Forms.ProgressBar();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.CertificateBox = new System.Windows.Forms.GroupBox();
            this.TemplateBrowseBtn = new System.Windows.Forms.Button();
            this.TemplatePath = new System.Windows.Forms.TextBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.OpenTemplate = new System.Windows.Forms.OpenFileDialog();
            this.CertificatedLabel = new System.Windows.Forms.Label();
            this.CertifiedPath = new System.Windows.Forms.TextBox();
            this.CertifiedBrowse = new System.Windows.Forms.Button();
            this.PositionXLabel = new System.Windows.Forms.Label();
            this.PositionX = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PositionYLabel = new System.Windows.Forms.Label();
            this.ProgressBox.SuspendLayout();
            this.CertificateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBox
            // 
            this.ProgressBox.Controls.Add(this.ProgressText);
            this.ProgressBox.Controls.Add(this.ProgressLabel);
            this.ProgressBox.Controls.Add(this.CancelBtn);
            this.ProgressBox.Controls.Add(this.CreationProgress);
            this.ProgressBox.Location = new System.Drawing.Point(12, 283);
            this.ProgressBox.Name = "ProgressBox";
            this.ProgressBox.Size = new System.Drawing.Size(433, 123);
            this.ProgressBox.TabIndex = 0;
            this.ProgressBox.TabStop = false;
            this.ProgressBox.Text = "Progress";
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Location = new System.Drawing.Point(6, 72);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(123, 13);
            this.ProgressText.TabIndex = 3;
            this.ProgressText.Text = "Certificates configuration";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(7, 25);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(24, 13);
            this.ProgressLabel.TabIndex = 2;
            this.ProgressLabel.Text = "0 %";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(352, 94);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // CreationProgress
            // 
            this.CreationProgress.Location = new System.Drawing.Point(6, 42);
            this.CreationProgress.Name = "CreationProgress";
            this.CreationProgress.Size = new System.Drawing.Size(421, 23);
            this.CreationProgress.TabIndex = 0;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(370, 12);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(75, 23);
            this.HelpBtn.TabIndex = 0;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            // 
            // CertificateBox
            // 
            this.CertificateBox.Controls.Add(this.PositionYLabel);
            this.CertificateBox.Controls.Add(this.textBox1);
            this.CertificateBox.Controls.Add(this.PositionX);
            this.CertificateBox.Controls.Add(this.PositionXLabel);
            this.CertificateBox.Controls.Add(this.CertifiedBrowse);
            this.CertificateBox.Controls.Add(this.CertifiedPath);
            this.CertificateBox.Controls.Add(this.CertificatedLabel);
            this.CertificateBox.Controls.Add(this.TemplateBrowseBtn);
            this.CertificateBox.Controls.Add(this.TemplatePath);
            this.CertificateBox.Controls.Add(this.TemplateLabel);
            this.CertificateBox.Location = new System.Drawing.Point(12, 45);
            this.CertificateBox.Name = "CertificateBox";
            this.CertificateBox.Size = new System.Drawing.Size(433, 201);
            this.CertificateBox.TabIndex = 2;
            this.CertificateBox.TabStop = false;
            this.CertificateBox.Text = "Certificate";
            // 
            // TemplateBrowseBtn
            // 
            this.TemplateBrowseBtn.Location = new System.Drawing.Point(348, 40);
            this.TemplateBrowseBtn.Name = "TemplateBrowseBtn";
            this.TemplateBrowseBtn.Size = new System.Drawing.Size(66, 20);
            this.TemplateBrowseBtn.TabIndex = 2;
            this.TemplateBrowseBtn.Text = "Browse";
            this.TemplateBrowseBtn.UseVisualStyleBackColor = true;
            this.TemplateBrowseBtn.Click += new System.EventHandler(this.TemplateBrowseBtn_Click);
            // 
            // TemplatePath
            // 
            this.TemplatePath.Enabled = false;
            this.TemplatePath.Location = new System.Drawing.Point(92, 40);
            this.TemplatePath.Name = "TemplatePath";
            this.TemplatePath.Size = new System.Drawing.Size(250, 20);
            this.TemplatePath.TabIndex = 1;
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(24, 43);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(54, 13);
            this.TemplateLabel.TabIndex = 0;
            this.TemplateLabel.Text = "Template:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(370, 254);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // OpenTemplate
            // 
            this.OpenTemplate.FileName = "CertificateTemplate";
            // 
            // CertificatedLabel
            // 
            this.CertificatedLabel.AutoSize = true;
            this.CertificatedLabel.Location = new System.Drawing.Point(11, 91);
            this.CertificatedLabel.Name = "CertificatedLabel";
            this.CertificatedLabel.Size = new System.Drawing.Size(67, 13);
            this.CertificatedLabel.TabIndex = 3;
            this.CertificatedLabel.Text = "Certified File:";
            // 
            // CertifiedPath
            // 
            this.CertifiedPath.Enabled = false;
            this.CertifiedPath.Location = new System.Drawing.Point(92, 87);
            this.CertifiedPath.Name = "CertifiedPath";
            this.CertifiedPath.Size = new System.Drawing.Size(250, 20);
            this.CertifiedPath.TabIndex = 4;
            // 
            // CertifiedBrowse
            // 
            this.CertifiedBrowse.Location = new System.Drawing.Point(348, 87);
            this.CertifiedBrowse.Name = "CertifiedBrowse";
            this.CertifiedBrowse.Size = new System.Drawing.Size(66, 20);
            this.CertifiedBrowse.TabIndex = 5;
            this.CertifiedBrowse.Text = "Browse";
            this.CertifiedBrowse.UseVisualStyleBackColor = true;
            // 
            // PositionXLabel
            // 
            this.PositionXLabel.AutoSize = true;
            this.PositionXLabel.Location = new System.Drawing.Point(21, 132);
            this.PositionXLabel.Name = "PositionXLabel";
            this.PositionXLabel.Size = new System.Drawing.Size(57, 13);
            this.PositionXLabel.TabIndex = 6;
            this.PositionXLabel.Text = "Position X:";
            // 
            // PositionX
            // 
            this.PositionX.Location = new System.Drawing.Point(92, 129);
            this.PositionX.Name = "PositionX";
            this.PositionX.Size = new System.Drawing.Size(71, 20);
            this.PositionX.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 8;
            // 
            // PositionYLabel
            // 
            this.PositionYLabel.AutoSize = true;
            this.PositionYLabel.Location = new System.Drawing.Point(193, 132);
            this.PositionYLabel.Name = "PositionYLabel";
            this.PositionYLabel.Size = new System.Drawing.Size(57, 13);
            this.PositionYLabel.TabIndex = 9;
            this.PositionYLabel.Text = "Position Y:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 413);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.CertificateBox);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.ProgressBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nateg Certificate Creator";
            this.ProgressBox.ResumeLayout(false);
            this.ProgressBox.PerformLayout();
            this.CertificateBox.ResumeLayout(false);
            this.CertificateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProgressBox;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ProgressBar CreationProgress;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.GroupBox CertificateBox;
        private System.Windows.Forms.TextBox TemplatePath;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button TemplateBrowseBtn;
        private System.Windows.Forms.OpenFileDialog OpenTemplate;
        private System.Windows.Forms.Label PositionYLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PositionX;
        private System.Windows.Forms.Label PositionXLabel;
        private System.Windows.Forms.Button CertifiedBrowse;
        private System.Windows.Forms.TextBox CertifiedPath;
        private System.Windows.Forms.Label CertificatedLabel;
    }
}

