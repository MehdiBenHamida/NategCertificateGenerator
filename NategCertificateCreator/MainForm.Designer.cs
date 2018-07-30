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
            this.OutputCheck = new System.Windows.Forms.CheckBox();
            this.AdvancedBtn = new System.Windows.Forms.Button();
            this.StandardCkeck = new System.Windows.Forms.CheckBox();
            this.OutputBrowseBtn = new System.Windows.Forms.Button();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.AdvancedPoliceBtn = new System.Windows.Forms.Button();
            this.StandardPolice = new System.Windows.Forms.CheckBox();
            this.TextLebel = new System.Windows.Forms.Label();
            this.PositionYLabel = new System.Windows.Forms.Label();
            this.PositionY = new System.Windows.Forms.TextBox();
            this.PositionX = new System.Windows.Forms.TextBox();
            this.PositionXLabel = new System.Windows.Forms.Label();
            this.CertifiedBrowse = new System.Windows.Forms.Button();
            this.CertifiedPath = new System.Windows.Forms.TextBox();
            this.CertificatedLabel = new System.Windows.Forms.Label();
            this.TemplateBrowseBtn = new System.Windows.Forms.Button();
            this.TemplatePath = new System.Windows.Forms.TextBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.OpenTemplate = new System.Windows.Forms.OpenFileDialog();
            this.OpenCertifiedFile = new System.Windows.Forms.OpenFileDialog();
            this.OutputBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.BeautificationCheck = new System.Windows.Forms.CheckBox();
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
            this.ProgressBox.Enabled = false;
            this.ProgressBox.Location = new System.Drawing.Point(12, 376);
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
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
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
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // CertificateBox
            // 
            this.CertificateBox.Controls.Add(this.BeautificationCheck);
            this.CertificateBox.Controls.Add(this.OutputCheck);
            this.CertificateBox.Controls.Add(this.AdvancedBtn);
            this.CertificateBox.Controls.Add(this.StandardCkeck);
            this.CertificateBox.Controls.Add(this.OutputBrowseBtn);
            this.CertificateBox.Controls.Add(this.OutputPath);
            this.CertificateBox.Controls.Add(this.OutputLabel);
            this.CertificateBox.Controls.Add(this.AdvancedPoliceBtn);
            this.CertificateBox.Controls.Add(this.StandardPolice);
            this.CertificateBox.Controls.Add(this.TextLebel);
            this.CertificateBox.Controls.Add(this.PositionYLabel);
            this.CertificateBox.Controls.Add(this.PositionY);
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
            this.CertificateBox.Size = new System.Drawing.Size(433, 303);
            this.CertificateBox.TabIndex = 2;
            this.CertificateBox.TabStop = false;
            this.CertificateBox.Text = "Certificate";
            // 
            // OutputCheck
            // 
            this.OutputCheck.AutoSize = true;
            this.OutputCheck.Checked = true;
            this.OutputCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutputCheck.Location = new System.Drawing.Point(92, 271);
            this.OutputCheck.Name = "OutputCheck";
            this.OutputCheck.Size = new System.Drawing.Size(128, 17);
            this.OutputCheck.TabIndex = 18;
            this.OutputCheck.Text = "Output description file";
            this.OutputCheck.UseVisualStyleBackColor = true;
            // 
            // AdvancedBtn
            // 
            this.AdvancedBtn.Enabled = false;
            this.AdvancedBtn.Location = new System.Drawing.Point(251, 119);
            this.AdvancedBtn.Name = "AdvancedBtn";
            this.AdvancedBtn.Size = new System.Drawing.Size(91, 20);
            this.AdvancedBtn.TabIndex = 17;
            this.AdvancedBtn.Text = "Advanced";
            this.AdvancedBtn.UseVisualStyleBackColor = true;
            this.AdvancedBtn.Click += new System.EventHandler(this.AdvancedBtn_Click);
            // 
            // StandardCkeck
            // 
            this.StandardCkeck.AutoSize = true;
            this.StandardCkeck.Checked = true;
            this.StandardCkeck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StandardCkeck.Location = new System.Drawing.Point(92, 122);
            this.StandardCkeck.Name = "StandardCkeck";
            this.StandardCkeck.Size = new System.Drawing.Size(153, 17);
            this.StandardCkeck.TabIndex = 16;
            this.StandardCkeck.Text = "Standard csv configuration";
            this.StandardCkeck.UseVisualStyleBackColor = true;
            this.StandardCkeck.CheckedChanged += new System.EventHandler(this.StandardCkeck_CheckedChanged);
            // 
            // OutputBrowseBtn
            // 
            this.OutputBrowseBtn.Location = new System.Drawing.Point(348, 244);
            this.OutputBrowseBtn.Name = "OutputBrowseBtn";
            this.OutputBrowseBtn.Size = new System.Drawing.Size(66, 20);
            this.OutputBrowseBtn.TabIndex = 15;
            this.OutputBrowseBtn.Text = "Browse";
            this.OutputBrowseBtn.UseVisualStyleBackColor = true;
            this.OutputBrowseBtn.Click += new System.EventHandler(this.OutputBrowseBtn_Click);
            // 
            // OutputPath
            // 
            this.OutputPath.Enabled = false;
            this.OutputPath.Location = new System.Drawing.Point(92, 244);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(250, 20);
            this.OutputPath.TabIndex = 14;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(36, 247);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel.TabIndex = 13;
            this.OutputLabel.Text = "Output:";
            // 
            // AdvancedPoliceBtn
            // 
            this.AdvancedPoliceBtn.Enabled = false;
            this.AdvancedPoliceBtn.Location = new System.Drawing.Point(236, 190);
            this.AdvancedPoliceBtn.Name = "AdvancedPoliceBtn";
            this.AdvancedPoliceBtn.Size = new System.Drawing.Size(106, 20);
            this.AdvancedPoliceBtn.TabIndex = 12;
            this.AdvancedPoliceBtn.Text = "Advanced Police";
            this.AdvancedPoliceBtn.UseVisualStyleBackColor = true;
            this.AdvancedPoliceBtn.Click += new System.EventHandler(this.AdvancedPoliceBtn_Click);
            // 
            // StandardPolice
            // 
            this.StandardPolice.AutoSize = true;
            this.StandardPolice.Checked = true;
            this.StandardPolice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StandardPolice.Location = new System.Drawing.Point(236, 166);
            this.StandardPolice.Name = "StandardPolice";
            this.StandardPolice.Size = new System.Drawing.Size(101, 17);
            this.StandardPolice.TabIndex = 11;
            this.StandardPolice.Text = "Standard Police";
            this.StandardPolice.UseVisualStyleBackColor = true;
            this.StandardPolice.CheckedChanged += new System.EventHandler(this.StandardPolice_CheckedChanged);
            // 
            // TextLebel
            // 
            this.TextLebel.AutoSize = true;
            this.TextLebel.Location = new System.Drawing.Point(47, 157);
            this.TextLebel.Name = "TextLebel";
            this.TextLebel.Size = new System.Drawing.Size(31, 13);
            this.TextLebel.TabIndex = 10;
            this.TextLebel.Text = "Text:";
            // 
            // PositionYLabel
            // 
            this.PositionYLabel.AutoSize = true;
            this.PositionYLabel.Location = new System.Drawing.Point(89, 193);
            this.PositionYLabel.Name = "PositionYLabel";
            this.PositionYLabel.Size = new System.Drawing.Size(57, 13);
            this.PositionYLabel.TabIndex = 9;
            this.PositionYLabel.Text = "Position Y:";
            // 
            // PositionY
            // 
            this.PositionY.Location = new System.Drawing.Point(152, 190);
            this.PositionY.Name = "PositionY";
            this.PositionY.Size = new System.Drawing.Size(71, 20);
            this.PositionY.TabIndex = 8;
            // 
            // PositionX
            // 
            this.PositionX.Location = new System.Drawing.Point(152, 164);
            this.PositionX.Name = "PositionX";
            this.PositionX.Size = new System.Drawing.Size(71, 20);
            this.PositionX.TabIndex = 7;
            // 
            // PositionXLabel
            // 
            this.PositionXLabel.AutoSize = true;
            this.PositionXLabel.Location = new System.Drawing.Point(89, 167);
            this.PositionXLabel.Name = "PositionXLabel";
            this.PositionXLabel.Size = new System.Drawing.Size(57, 13);
            this.PositionXLabel.TabIndex = 6;
            this.PositionXLabel.Text = "Position X:";
            // 
            // CertifiedBrowse
            // 
            this.CertifiedBrowse.Location = new System.Drawing.Point(348, 87);
            this.CertifiedBrowse.Name = "CertifiedBrowse";
            this.CertifiedBrowse.Size = new System.Drawing.Size(66, 20);
            this.CertifiedBrowse.TabIndex = 5;
            this.CertifiedBrowse.Text = "Browse";
            this.CertifiedBrowse.UseVisualStyleBackColor = true;
            this.CertifiedBrowse.Click += new System.EventHandler(this.CertifiedBrowse_Click);
            // 
            // CertifiedPath
            // 
            this.CertifiedPath.Enabled = false;
            this.CertifiedPath.Location = new System.Drawing.Point(92, 87);
            this.CertifiedPath.Name = "CertifiedPath";
            this.CertifiedPath.Size = new System.Drawing.Size(250, 20);
            this.CertifiedPath.TabIndex = 4;
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
            this.CreateBtn.Location = new System.Drawing.Point(370, 354);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // OpenTemplate
            // 
            this.OpenTemplate.FileName = "CertificateTemplate";
            // 
            // OpenCertifiedFile
            // 
            this.OpenCertifiedFile.FileName = "Certified";
            // 
            // BeautificationCheck
            // 
            this.BeautificationCheck.AutoSize = true;
            this.BeautificationCheck.Location = new System.Drawing.Point(92, 218);
            this.BeautificationCheck.Name = "BeautificationCheck";
            this.BeautificationCheck.Size = new System.Drawing.Size(126, 17);
            this.BeautificationCheck.TabIndex = 19;
            this.BeautificationCheck.Text = "Names Beautification";
            this.BeautificationCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 505);
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
        private System.Windows.Forms.TextBox PositionY;
        private System.Windows.Forms.TextBox PositionX;
        private System.Windows.Forms.Label PositionXLabel;
        private System.Windows.Forms.Button CertifiedBrowse;
        private System.Windows.Forms.TextBox CertifiedPath;
        private System.Windows.Forms.Label CertificatedLabel;
        private System.Windows.Forms.Button AdvancedPoliceBtn;
        private System.Windows.Forms.CheckBox StandardPolice;
        private System.Windows.Forms.Label TextLebel;
        private System.Windows.Forms.Button OutputBrowseBtn;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button AdvancedBtn;
        private System.Windows.Forms.CheckBox StandardCkeck;
        private System.Windows.Forms.CheckBox OutputCheck;
        private System.Windows.Forms.OpenFileDialog OpenCertifiedFile;
        private System.Windows.Forms.FolderBrowserDialog OutputBrowse;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.CheckBox BeautificationCheck;
    }
}

