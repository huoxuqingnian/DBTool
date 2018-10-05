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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = string.Format("Version {0}  LastUpdate：{1}", "1.0", DateTime.Now.ToShortDateString());
        }

        private void menuItem_About_Click(object sender, EventArgs e)
        {
            new Form_MenuItem_About().ShowDialog();
        }

        private void menuItem_DataBase_Click(object sender, EventArgs e)
        {
            new Form_DBAbout().ShowDialog();
        }
    }
}
