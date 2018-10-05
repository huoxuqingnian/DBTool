namespace DBTool
{
    partial class Form_DBAbout
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
            this.radioButton_DBString = new System.Windows.Forms.RadioButton();
            this.radioButton_DBParameter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_DBString = new System.Windows.Forms.Panel();
            this.textBox_DBString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_DBParameter = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_DBChoose = new System.Windows.Forms.ComboBox();
            this.textBox_Unicode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DataSource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.panel_DBString.SuspendLayout();
            this.panel_DBParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_DBString
            // 
            this.radioButton_DBString.AutoSize = true;
            this.radioButton_DBString.Location = new System.Drawing.Point(163, 12);
            this.radioButton_DBString.Name = "radioButton_DBString";
            this.radioButton_DBString.Size = new System.Drawing.Size(119, 16);
            this.radioButton_DBString.TabIndex = 0;
            this.radioButton_DBString.TabStop = true;
            this.radioButton_DBString.Text = "数据库连接字符串";
            this.radioButton_DBString.UseVisualStyleBackColor = true;
            this.radioButton_DBString.CheckedChanged += new System.EventHandler(this.radioButton_DBString_CheckedChanged);
            // 
            // radioButton_DBParameter
            // 
            this.radioButton_DBParameter.AutoSize = true;
            this.radioButton_DBParameter.Location = new System.Drawing.Point(319, 12);
            this.radioButton_DBParameter.Name = "radioButton_DBParameter";
            this.radioButton_DBParameter.Size = new System.Drawing.Size(107, 16);
            this.radioButton_DBParameter.TabIndex = 1;
            this.radioButton_DBParameter.TabStop = true;
            this.radioButton_DBParameter.Text = "数据库连接参数";
            this.radioButton_DBParameter.UseVisualStyleBackColor = true;
            this.radioButton_DBParameter.CheckedChanged += new System.EventHandler(this.radioButton_DBParameter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择数据库连接方式：";
            // 
            // panel_DBString
            // 
            this.panel_DBString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_DBString.Controls.Add(this.textBox_DBString);
            this.panel_DBString.Controls.Add(this.label2);
            this.panel_DBString.Location = new System.Drawing.Point(12, 34);
            this.panel_DBString.Name = "panel_DBString";
            this.panel_DBString.Size = new System.Drawing.Size(525, 76);
            this.panel_DBString.TabIndex = 3;
            // 
            // textBox_DBString
            // 
            this.textBox_DBString.Location = new System.Drawing.Point(118, 15);
            this.textBox_DBString.Multiline = true;
            this.textBox_DBString.Name = "textBox_DBString";
            this.textBox_DBString.Size = new System.Drawing.Size(390, 42);
            this.textBox_DBString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据库连接字符串：";
            // 
            // panel_DBParameter
            // 
            this.panel_DBParameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_DBParameter.Controls.Add(this.label8);
            this.panel_DBParameter.Controls.Add(this.comboBox_DBChoose);
            this.panel_DBParameter.Controls.Add(this.textBox_Unicode);
            this.panel_DBParameter.Controls.Add(this.label7);
            this.panel_DBParameter.Controls.Add(this.textBox_Password);
            this.panel_DBParameter.Controls.Add(this.label6);
            this.panel_DBParameter.Controls.Add(this.textBox_UserID);
            this.panel_DBParameter.Controls.Add(this.label5);
            this.panel_DBParameter.Controls.Add(this.textBox_DataSource);
            this.panel_DBParameter.Controls.Add(this.label4);
            this.panel_DBParameter.Controls.Add(this.label3);
            this.panel_DBParameter.Location = new System.Drawing.Point(12, 116);
            this.panel_DBParameter.Name = "panel_DBParameter";
            this.panel_DBParameter.Size = new System.Drawing.Size(525, 131);
            this.panel_DBParameter.TabIndex = 4;
            this.panel_DBParameter.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "数据库选择：";
            // 
            // comboBox_DBChoose
            // 
            this.comboBox_DBChoose.FormattingEnabled = true;
            this.comboBox_DBChoose.Location = new System.Drawing.Point(192, 14);
            this.comboBox_DBChoose.Name = "comboBox_DBChoose";
            this.comboBox_DBChoose.Size = new System.Drawing.Size(121, 20);
            this.comboBox_DBChoose.TabIndex = 9;
            // 
            // textBox_Unicode
            // 
            this.textBox_Unicode.Location = new System.Drawing.Point(408, 95);
            this.textBox_Unicode.Name = "textBox_Unicode";
            this.textBox_Unicode.Size = new System.Drawing.Size(100, 21);
            this.textBox_Unicode.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Unicode：";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(408, 68);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 21);
            this.textBox_Password.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password：";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(408, 41);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(100, 21);
            this.textBox_UserID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "User ID：";
            // 
            // textBox_DataSource
            // 
            this.textBox_DataSource.Location = new System.Drawing.Point(408, 14);
            this.textBox_DataSource.Name = "textBox_DataSource";
            this.textBox_DataSource.Size = new System.Drawing.Size(100, 21);
            this.textBox_DataSource.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Source：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库连接参数：";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(445, 268);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 3;
            this.button_Submit.Text = "确 认";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(319, 268);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "清 空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_DBAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 303);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.panel_DBParameter);
            this.Controls.Add(this.panel_DBString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_DBParameter);
            this.Controls.Add(this.radioButton_DBString);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DBAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库相关";
            this.panel_DBString.ResumeLayout(false);
            this.panel_DBString.PerformLayout();
            this.panel_DBParameter.ResumeLayout(false);
            this.panel_DBParameter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_DBString;
        private System.Windows.Forms.RadioButton radioButton_DBParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_DBString;
        private System.Windows.Forms.Panel panel_DBParameter;
        private System.Windows.Forms.TextBox textBox_DBString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Unicode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DataSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_DBChoose;
    }
}