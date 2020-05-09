namespace Student.UI
{
    partial class 登录系统
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
            this.student_select = new System.Windows.Forms.RadioButton();
            this.admin_select = new System.Windows.Forms.RadioButton();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SureBtn = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.userID_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // student_select
            // 
            this.student_select.AutoSize = true;
            this.student_select.Location = new System.Drawing.Point(179, 110);
            this.student_select.Margin = new System.Windows.Forms.Padding(2);
            this.student_select.Name = "student_select";
            this.student_select.Size = new System.Drawing.Size(47, 16);
            this.student_select.TabIndex = 15;
            this.student_select.TabStop = true;
            this.student_select.Text = "学生";
            this.student_select.UseVisualStyleBackColor = true;
            // 
            // admin_select
            // 
            this.admin_select.AutoSize = true;
            this.admin_select.Location = new System.Drawing.Point(84, 110);
            this.admin_select.Margin = new System.Windows.Forms.Padding(2);
            this.admin_select.Name = "admin_select";
            this.admin_select.Size = new System.Drawing.Size(47, 16);
            this.admin_select.TabIndex = 14;
            this.admin_select.TabStop = true;
            this.admin_select.Text = "教师";
            this.admin_select.UseVisualStyleBackColor = true;
            this.admin_select.CheckedChanged += new System.EventHandler(this.admin_select_CheckedChanged);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(179, 151);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(75, 32);
            this.QuitBtn.TabIndex = 13;
            this.QuitBtn.Text = "取消登录";
            this.QuitBtn.UseVisualStyleBackColor = true;
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(56, 151);
            this.SureBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(75, 32);
            this.SureBtn.TabIndex = 12;
            this.SureBtn.Text = "确认登录";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(112, 66);
            this.password_input.Margin = new System.Windows.Forms.Padding(2);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(142, 21);
            this.password_input.TabIndex = 11;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // userID_input
            // 
            this.userID_input.Location = new System.Drawing.Point(112, 28);
            this.userID_input.Margin = new System.Windows.Forms.Padding(2);
            this.userID_input.Name = "userID_input";
            this.userID_input.Size = new System.Drawing.Size(142, 21);
            this.userID_input.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Copyright ©2016 Hange 版权所有";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "id = 201630135034";
            // 
            // 登录系统
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.student_select);
            this.Controls.Add(this.admin_select);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.userID_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "登录系统";
            this.Text = "欢迎登陆学生管理系统";
            this.Load += new System.EventHandler(this.登录系统_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton student_select;
        private System.Windows.Forms.RadioButton admin_select;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox userID_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}