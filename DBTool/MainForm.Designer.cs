namespace DBTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_ExportSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Tool,
            this.menuItem_Help,
            this.menuItem_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_Tool
            // 
            this.menuItem_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_DataBase,
            this.toolStripSeparator1,
            this.menuItem_ExportSetting,
            this.menuItem_Option});
            this.menuItem_Tool.Name = "menuItem_Tool";
            this.menuItem_Tool.Size = new System.Drawing.Size(59, 21);
            this.menuItem_Tool.Text = "工具(T)";
            // 
            // menuItem_DataBase
            // 
            this.menuItem_DataBase.Name = "menuItem_DataBase";
            this.menuItem_DataBase.Size = new System.Drawing.Size(153, 22);
            this.menuItem_DataBase.Text = "数据库相关(D)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // menuItem_ExportSetting
            // 
            this.menuItem_ExportSetting.Name = "menuItem_ExportSetting";
            this.menuItem_ExportSetting.Size = new System.Drawing.Size(153, 22);
            this.menuItem_ExportSetting.Text = "导出设置(I)";
            // 
            // menuItem_Option
            // 
            this.menuItem_Option.Name = "menuItem_Option";
            this.menuItem_Option.Size = new System.Drawing.Size(153, 22);
            this.menuItem_Option.Text = "选项(O)";
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.Name = "menuItem_Help";
            this.menuItem_Help.Size = new System.Drawing.Size(61, 21);
            this.menuItem_Help.Text = "帮助(H)";
            // 
            // menuItem_About
            // 
            this.menuItem_About.Name = "menuItem_About";
            this.menuItem_About.Size = new System.Drawing.Size(60, 21);
            this.menuItem_About.Text = "关于(A)";
            this.menuItem_About.Click += new System.EventHandler(this.menuItem_About_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 302);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库工具 Version 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Tool;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DataBase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ExportSetting;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Option;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem menuItem_About;
    }
}

