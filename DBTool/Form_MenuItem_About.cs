using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTool
{
    public partial class Form_MenuItem_About : Form
    {
        public Form_MenuItem_About()
        {
            InitializeComponent();
        }

        private void about_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = about_LinkLabel1.Text;
            //System.Diagnostics.Process.Start("iexplore.exe", url);
            System.Diagnostics.Process.Start("firefox.exe", url);
        }
    }
}
