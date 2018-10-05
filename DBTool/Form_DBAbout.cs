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
    public partial class Form_DBAbout : Form
    {
        public Form_DBAbout()
        {
            InitializeComponent();
            XmlOperation xo = new XmlOperation("D:\\Documents\\Visual Studio 2013\\Projects\\DBTool\\DBTool\\Config\\DBSetting.xml");  
            this.textBox_DBString.Text = xo.QueryElementAttribute("DBSetting", "ConnectionString");
        }

        private void radioButton_DBString_CheckedChanged(object sender, EventArgs e)
        {
            /*
             选中则显示,不选中则不显示
             */
            if (radioButton_DBString.Checked)
            {
                panel_DBString.Visible = true;
            }
            if (!radioButton_DBString.Checked)
            {
                panel_DBString.Visible = false;
            }
        }

        private void radioButton_DBParameter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_DBParameter.Checked)
            {
                panel_DBParameter.Visible = true;
            }
            if (!radioButton_DBParameter.Checked)
            {
                panel_DBParameter.Visible = false;
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            /*
             数据库连接字符串
             */
            if (radioButton_DBString.Checked)
            {
                textBox_DBString.Text = string.Empty;
            }
            /*
             数据库连接参数
             */
            if (radioButton_DBParameter.Checked)
            {
                textBox_DataSource.Text = string.Empty;
                textBox_UserID.Text = string.Empty;
                textBox_Password.Text = string.Empty;
                textBox_Unicode.Text = string.Empty;
            }
        }
    }
}
