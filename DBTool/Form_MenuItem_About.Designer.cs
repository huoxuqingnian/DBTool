namespace DBTool
{
    partial class Form_MenuItem_About
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
            this.about_LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.about_Label1 = new System.Windows.Forms.Label();
            this.about_Label2 = new System.Windows.Forms.Label();
            this.about_Label3 = new System.Windows.Forms.Label();
            this.about_Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // about_LinkLabel1
            // 
            this.about_LinkLabel1.AutoSize = true;
            this.about_LinkLabel1.Location = new System.Drawing.Point(93, 48);
            this.about_LinkLabel1.Name = "about_LinkLabel1";
            this.about_LinkLabel1.Size = new System.Drawing.Size(239, 12);
            this.about_LinkLabel1.TabIndex = 0;
            this.about_LinkLabel1.TabStop = true;
            this.about_LinkLabel1.Text = "https://github.com/huoxuqingnian/DBTool";
            this.about_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.about_LinkLabel1_LinkClicked);
            // 
            // about_Label1
            // 
            this.about_Label1.AutoSize = true;
            this.about_Label1.Location = new System.Drawing.Point(12, 26);
            this.about_Label1.Name = "about_Label1";
            this.about_Label1.Size = new System.Drawing.Size(215, 12);
            this.about_Label1.TabIndex = 1;
            this.about_Label1.Text = "项目确定时间：2018-09-06 00：00：00";
            // 
            // about_Label2
            // 
            this.about_Label2.AutoSize = true;
            this.about_Label2.Location = new System.Drawing.Point(12, 48);
            this.about_Label2.Name = "about_Label2";
            this.about_Label2.Size = new System.Drawing.Size(83, 12);
            this.about_Label2.TabIndex = 2;
            this.about_Label2.Text = "GitHub 链接：";
            // 
            // about_Label3
            // 
            this.about_Label3.AutoSize = true;
            this.about_Label3.Location = new System.Drawing.Point(11, 70);
            this.about_Label3.Name = "about_Label3";
            this.about_Label3.Size = new System.Drawing.Size(131, 12);
            this.about_Label3.TabIndex = 3;
            this.about_Label3.Text = "当前版本：Version 1.0";
            // 
            // about_Label4
            // 
            this.about_Label4.AutoSize = true;
            this.about_Label4.Location = new System.Drawing.Point(11, 92);
            this.about_Label4.Name = "about_Label4";
            this.about_Label4.Size = new System.Drawing.Size(65, 12);
            this.about_Label4.TabIndex = 4;
            this.about_Label4.Text = "作者：田鹏";
            // 
            // Form_MenuItem_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 133);
            this.Controls.Add(this.about_Label4);
            this.Controls.Add(this.about_Label3);
            this.Controls.Add(this.about_Label2);
            this.Controls.Add(this.about_Label1);
            this.Controls.Add(this.about_LinkLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_MenuItem_About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel about_LinkLabel1;
        private System.Windows.Forms.Label about_Label1;
        private System.Windows.Forms.Label about_Label2;
        private System.Windows.Forms.Label about_Label3;
        private System.Windows.Forms.Label about_Label4;
    }
}