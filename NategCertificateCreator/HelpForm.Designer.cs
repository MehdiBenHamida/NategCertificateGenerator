namespace NategCertificateCreator
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.UserNotes = new System.Windows.Forms.GroupBox();
            this.UserNoteLabel = new System.Windows.Forms.Label();
            this.License = new System.Windows.Forms.GroupBox();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.GroupBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UserNotes.SuspendLayout();
            this.License.SuspendLayout();
            this.Contact.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNotes
            // 
            this.UserNotes.Controls.Add(this.UserNoteLabel);
            this.UserNotes.Location = new System.Drawing.Point(12, 12);
            this.UserNotes.Name = "UserNotes";
            this.UserNotes.Size = new System.Drawing.Size(404, 116);
            this.UserNotes.TabIndex = 0;
            this.UserNotes.TabStop = false;
            this.UserNotes.Text = "User Notes";
            // 
            // UserNoteLabel
            // 
            this.UserNoteLabel.AutoSize = true;
            this.UserNoteLabel.Location = new System.Drawing.Point(6, 24);
            this.UserNoteLabel.Name = "UserNoteLabel";
            this.UserNoteLabel.Size = new System.Drawing.Size(391, 78);
            this.UserNoteLabel.TabIndex = 0;
            this.UserNoteLabel.Text = resources.GetString("UserNoteLabel.Text");
            // 
            // License
            // 
            this.License.Controls.Add(this.LicenseLabel);
            this.License.Location = new System.Drawing.Point(12, 134);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(404, 88);
            this.License.TabIndex = 1;
            this.License.TabStop = false;
            this.License.Text = "License";
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Location = new System.Drawing.Point(6, 30);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(376, 39);
            this.LicenseLabel.TabIndex = 0;
            this.LicenseLabel.Text = "This software is under Mèhdi Ben Hamida property, and it\'s distributed under a \r\n" +
    "free and open source MIT license. More Informations on software repository in \r\n" +
    "github.\r\n";
            // 
            // Contact
            // 
            this.Contact.Controls.Add(this.ContactLabel);
            this.Contact.Location = new System.Drawing.Point(12, 231);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(404, 65);
            this.Contact.TabIndex = 2;
            this.Contact.TabStop = false;
            this.Contact.Text = "Contact";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(6, 26);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(186, 26);
            this.ContactLabel.TabIndex = 0;
            this.ContactLabel.Text = "Email: mehdi.benhamida@ensi-uma.tn\r\nTel: +216 23 922 380 ";
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(58, 309);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(299, 13);
            this.GithubLink.TabIndex = 3;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "https://github.com/MehdiBenHamida/NategCertificateCreator";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(341, 339);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 364);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.License);
            this.Controls.Add(this.UserNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.UserNotes.ResumeLayout(false);
            this.UserNotes.PerformLayout();
            this.License.ResumeLayout(false);
            this.License.PerformLayout();
            this.Contact.ResumeLayout(false);
            this.Contact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserNotes;
        private System.Windows.Forms.Label UserNoteLabel;
        private System.Windows.Forms.GroupBox License;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.GroupBox Contact;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Button CloseBtn;
    }
}