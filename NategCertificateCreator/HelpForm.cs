﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NategCertificateCreator
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GithubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MehdiBenHamida/NategMailsSender");
        }
    }
}
