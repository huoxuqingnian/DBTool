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
        #region
        private string dbstring = string.Empty;
        private string dbstring_conn = string.Empty;
        private static string xmlFileName = "D:\\Documents\\Visual Studio 2013\\Projects\\DBTool\\DBTool\\Config\\DBSetting.xml";
        private static XmlOperation xo = new XmlOperation();  

        #endregion
        public Form_DBAbout()
        {
            InitializeComponent();
            xo = new XmlOperation(xmlFileName);
            this.textBox_DBString.Text = xo.QueryElementAttribute(null, "CustomSetting", "ConnectionString");
            this.dbstring = this.textBox_DBString.Text;
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
                textBox_DBString.Text = dbstring;
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
            string dbstring_new = this.textBox_DBString.Text;
            if (dbstring == dbstring_new)
            {
                this.Close();
                return;
            }
            else
            {
                dbstring = dbstring_new;
                xo.UpdateElementAttribute(xo.RootNodeName, "CustomSetting", "ConnectionString", dbstring_new);
            }
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

        private void button_ConnectionTest_Click(object sender, EventArgs e)
        {
            DatabaseOperation dbOpera = new DatabaseOperation(textBox_DBString.Text);
            bool isCanConn = dbOpera.ConnectionTest();
            if (isCanConn)
            {
                this.dbstring_conn = textBox_DBString.Text;
            }
            button_Submit.Enabled = isCanConn;
            string returnMessage = isCanConn ? "测试结果：测试通过，连接成功！" : "测试结果：连接失败！请检查数据库连接字符串";
            MessageBox.Show(returnMessage);
        }

        private void textBox_DBString_TextChanged(object sender, EventArgs e)
        {
            button_Submit.Enabled = (this.dbstring_conn != string.Empty && this.dbstring_conn == textBox_DBString.Text);
        }
    }
}
