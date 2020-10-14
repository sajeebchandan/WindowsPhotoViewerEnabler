using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPhotoViewerEnabler
{
    public partial class About : Form
    {
        private FileVersionInfo fileVersion = null;
        public About()
        {
            InitializeComponent();
            fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            labelVersion.Text = fileVersion.ProductName + " " + fileVersion.FileVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sajeebchandan");
        }
    }
}
