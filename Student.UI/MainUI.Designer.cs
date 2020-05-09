namespace Student.UI.student
{
    partial class MainUI
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
            this.QuitBtn3 = new System.Windows.Forms.Button();
            this.updatePassWordBtn = new System.Windows.Forms.Button();
            this.scoreViewByStudent = new System.Windows.Forms.DataGridView();
            this.Student_tabPage = new System.Windows.Forms.TabPage();
            this.selectCourseBtn = new System.Windows.Forms.Button();
            this.tutor_score_tabPage = new System.Windows.Forms.TabPage();
            this.QuitBtn2 = new System.Windows.Forms.Button();
            this.updateScoreBtn = new System.Windows.Forms.Button();
            this.selectScoreBtn = new System.Windows.Forms.Button();
            this.delScoreBtn = new System.Windows.Forms.Button();
            this.addScoreBtn = new System.Windows.Forms.Button();
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.StudentView = new System.Windows.Forms.DataGridView();
            this.selectStudentBtn = new System.Windows.Forms.Button();
            this.delStudentBtn = new System.Windows.Forms.Button();
            this.QuitBtn1 = new System.Windows.Forms.Button();
            this.updateStudentBtn = new System.Windows.Forms.Button();
            this.teacher_student_tabPage = new System.Windows.Forms.TabPage();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.scoreViewByStudent)).BeginInit();
            this.Student_tabPage.SuspendLayout();
            this.tutor_score_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            this.teacher_student_tabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuitBtn3
            // 
            this.QuitBtn3.Location = new System.Drawing.Point(466, 383);
            this.QuitBtn3.Margin = new System.Windows.Forms.Padding(2);
            this.QuitBtn3.Name = "QuitBtn3";
            this.QuitBtn3.Size = new System.Drawing.Size(75, 32);
            this.QuitBtn3.TabIndex = 4;
            this.QuitBtn3.Text = "退出系统";
            this.QuitBtn3.UseVisualStyleBackColor = true;
            this.QuitBtn3.Click += new System.EventHandler(this.QuitBtn3_Click_1);
            // 
            // updatePassWordBtn
            // 
            this.updatePassWordBtn.Location = new System.Drawing.Point(247, 383);
            this.updatePassWordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updatePassWordBtn.Name = "updatePassWordBtn";
            this.updatePassWordBtn.Size = new System.Drawing.Size(75, 32);
            this.updatePassWordBtn.TabIndex = 3;
            this.updatePassWordBtn.Text = "修改密码";
            this.updatePassWordBtn.UseVisualStyleBackColor = true;
            this.updatePassWordBtn.Click += new System.EventHandler(this.UpdatePassWordBtn_Click_1);
            // 
            // scoreViewByStudent
            // 
            this.scoreViewByStudent.AllowUserToAddRows = false;
            this.scoreViewByStudent.AllowUserToDeleteRows = false;
            this.scoreViewByStudent.AllowUserToResizeColumns = false;
            this.scoreViewByStudent.AllowUserToResizeRows = false;
            this.scoreViewByStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreViewByStudent.Location = new System.Drawing.Point(0, 0);
            this.scoreViewByStudent.Margin = new System.Windows.Forms.Padding(2);
            this.scoreViewByStudent.Name = "scoreViewByStudent";
            this.scoreViewByStudent.ReadOnly = true;
            this.scoreViewByStudent.RowTemplate.Height = 27;
            this.scoreViewByStudent.Size = new System.Drawing.Size(581, 376);
            this.scoreViewByStudent.TabIndex = 1;
            this.scoreViewByStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreViewByStudent_CellContentClick);
            // 
            // Student_tabPage
            // 
            this.Student_tabPage.Controls.Add(this.QuitBtn3);
            this.Student_tabPage.Controls.Add(this.updatePassWordBtn);
            this.Student_tabPage.Controls.Add(this.selectCourseBtn);
            this.Student_tabPage.Controls.Add(this.scoreViewByStudent);
            this.Student_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Student_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Student_tabPage.Name = "Student_tabPage";
            this.Student_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.Student_tabPage.Size = new System.Drawing.Size(581, 418);
            this.Student_tabPage.TabIndex = 2;
            this.Student_tabPage.Text = "学生成绩";
            this.Student_tabPage.UseVisualStyleBackColor = true;
            this.Student_tabPage.Click += new System.EventHandler(this.student_tabPage_Click);
            // 
            // selectCourseBtn
            // 
            this.selectCourseBtn.Location = new System.Drawing.Point(27, 383);
            this.selectCourseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectCourseBtn.Name = "selectCourseBtn";
            this.selectCourseBtn.Size = new System.Drawing.Size(75, 32);
            this.selectCourseBtn.TabIndex = 2;
            this.selectCourseBtn.Text = "查询科目";
            this.selectCourseBtn.UseVisualStyleBackColor = true;
            this.selectCourseBtn.Click += new System.EventHandler(this.SelectCourseBtn_Click_1);
            // 
            // tutor_score_tabPage
            // 
            this.tutor_score_tabPage.Controls.Add(this.QuitBtn2);
            this.tutor_score_tabPage.Controls.Add(this.updateScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.selectScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.delScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.addScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.scoreView);
            this.tutor_score_tabPage.Location = new System.Drawing.Point(4, 22);
            this.tutor_score_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tutor_score_tabPage.Name = "tutor_score_tabPage";
            this.tutor_score_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.tutor_score_tabPage.Size = new System.Drawing.Size(581, 418);
            this.tutor_score_tabPage.TabIndex = 1;
            this.tutor_score_tabPage.Text = "学生成绩";
            this.tutor_score_tabPage.UseVisualStyleBackColor = true;
            // 
            // QuitBtn2
            // 
            this.QuitBtn2.Location = new System.Drawing.Point(470, 381);
            this.QuitBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.QuitBtn2.Name = "QuitBtn2";
            this.QuitBtn2.Size = new System.Drawing.Size(75, 32);
            this.QuitBtn2.TabIndex = 10;
            this.QuitBtn2.Text = "退出系统";
            this.QuitBtn2.UseVisualStyleBackColor = true;
            this.QuitBtn2.Click += new System.EventHandler(this.QuitBtn2_Click);
            // 
            // updateScoreBtn
            // 
            this.updateScoreBtn.Location = new System.Drawing.Point(361, 381);
            this.updateScoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateScoreBtn.Name = "updateScoreBtn";
            this.updateScoreBtn.Size = new System.Drawing.Size(75, 32);
            this.updateScoreBtn.TabIndex = 9;
            this.updateScoreBtn.Text = "修改成绩";
            this.updateScoreBtn.UseVisualStyleBackColor = true;
            this.updateScoreBtn.Click += new System.EventHandler(this.UpdateScoreBtn_Click_1);
            // 
            // selectScoreBtn
            // 
            this.selectScoreBtn.Location = new System.Drawing.Point(252, 381);
            this.selectScoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectScoreBtn.Name = "selectScoreBtn";
            this.selectScoreBtn.Size = new System.Drawing.Size(75, 32);
            this.selectScoreBtn.TabIndex = 8;
            this.selectScoreBtn.Text = "查找成绩";
            this.selectScoreBtn.UseVisualStyleBackColor = true;
            this.selectScoreBtn.Click += new System.EventHandler(this.SelectScoreBtn_Click_1);
            // 
            // delScoreBtn
            // 
            this.delScoreBtn.Location = new System.Drawing.Point(143, 381);
            this.delScoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delScoreBtn.Name = "delScoreBtn";
            this.delScoreBtn.Size = new System.Drawing.Size(75, 32);
            this.delScoreBtn.TabIndex = 7;
            this.delScoreBtn.Text = "删除成绩";
            this.delScoreBtn.UseVisualStyleBackColor = true;
            this.delScoreBtn.Click += new System.EventHandler(this.DelScoreBtn_Click_1);
            // 
            // addScoreBtn
            // 
            this.addScoreBtn.Location = new System.Drawing.Point(34, 381);
            this.addScoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addScoreBtn.Name = "addScoreBtn";
            this.addScoreBtn.Size = new System.Drawing.Size(75, 32);
            this.addScoreBtn.TabIndex = 6;
            this.addScoreBtn.Text = "录入成绩";
            this.addScoreBtn.UseVisualStyleBackColor = true;
            this.addScoreBtn.Click += new System.EventHandler(this.AddScoreBtn_Click_1);
            // 
            // scoreView
            // 
            this.scoreView.AllowUserToAddRows = false;
            this.scoreView.AllowUserToDeleteRows = false;
            this.scoreView.AllowUserToResizeColumns = false;
            this.scoreView.AllowUserToResizeRows = false;
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Location = new System.Drawing.Point(0, 0);
            this.scoreView.Margin = new System.Windows.Forms.Padding(2);
            this.scoreView.Name = "scoreView";
            this.scoreView.ReadOnly = true;
            this.scoreView.RowTemplate.Height = 27;
            this.scoreView.Size = new System.Drawing.Size(581, 376);
            this.scoreView.TabIndex = 0;
            // 
            // StudentView
            // 
            this.StudentView.AllowUserToAddRows = false;
            this.StudentView.AllowUserToDeleteRows = false;
            this.StudentView.AllowUserToResizeColumns = false;
            this.StudentView.AllowUserToResizeRows = false;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentView.Location = new System.Drawing.Point(0, 0);
            this.StudentView.Margin = new System.Windows.Forms.Padding(2);
            this.StudentView.Name = "StudentView";
            this.StudentView.ReadOnly = true;
            this.StudentView.RowTemplate.Height = 27;
            this.StudentView.Size = new System.Drawing.Size(581, 376);
            this.StudentView.TabIndex = 0;
            // 
            // selectStudentBtn
            // 
            this.selectStudentBtn.Location = new System.Drawing.Point(252, 381);
            this.selectStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectStudentBtn.Name = "selectStudentBtn";
            this.selectStudentBtn.Size = new System.Drawing.Size(75, 32);
            this.selectStudentBtn.TabIndex = 3;
            this.selectStudentBtn.Text = "查找学生";
            this.selectStudentBtn.UseVisualStyleBackColor = true;
            this.selectStudentBtn.Click += new System.EventHandler(this.SelectStudentBtn_Click_1);
            // 
            // delStudentBtn
            // 
            this.delStudentBtn.Location = new System.Drawing.Point(143, 381);
            this.delStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delStudentBtn.Name = "delStudentBtn";
            this.delStudentBtn.Size = new System.Drawing.Size(75, 32);
            this.delStudentBtn.TabIndex = 2;
            this.delStudentBtn.Text = "删除学生";
            this.delStudentBtn.UseVisualStyleBackColor = true;
            this.delStudentBtn.Click += new System.EventHandler(this.DelStudentBtn_Click_1);
            // 
            // QuitBtn1
            // 
            this.QuitBtn1.Location = new System.Drawing.Point(470, 381);
            this.QuitBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.QuitBtn1.Name = "QuitBtn1";
            this.QuitBtn1.Size = new System.Drawing.Size(75, 32);
            this.QuitBtn1.TabIndex = 5;
            this.QuitBtn1.Text = "退出系统";
            this.QuitBtn1.UseVisualStyleBackColor = true;
            this.QuitBtn1.Click += new System.EventHandler(this.QuitBtn1_Click_1);
            // 
            // updateStudentBtn
            // 
            this.updateStudentBtn.Location = new System.Drawing.Point(361, 381);
            this.updateStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateStudentBtn.Name = "updateStudentBtn";
            this.updateStudentBtn.Size = new System.Drawing.Size(75, 32);
            this.updateStudentBtn.TabIndex = 4;
            this.updateStudentBtn.Text = "修改学生";
            this.updateStudentBtn.UseVisualStyleBackColor = true;
            this.updateStudentBtn.Click += new System.EventHandler(this.UpdateStudentBtn_Click_1);
            // 
            // teacher_student_tabPage
            // 
            this.teacher_student_tabPage.Controls.Add(this.QuitBtn1);
            this.teacher_student_tabPage.Controls.Add(this.updateStudentBtn);
            this.teacher_student_tabPage.Controls.Add(this.selectStudentBtn);
            this.teacher_student_tabPage.Controls.Add(this.delStudentBtn);
            this.teacher_student_tabPage.Controls.Add(this.addStudentBtn);
            this.teacher_student_tabPage.Controls.Add(this.StudentView);
            this.teacher_student_tabPage.Location = new System.Drawing.Point(4, 22);
            this.teacher_student_tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.teacher_student_tabPage.Name = "teacher_student_tabPage";
            this.teacher_student_tabPage.Padding = new System.Windows.Forms.Padding(2);
            this.teacher_student_tabPage.Size = new System.Drawing.Size(581, 418);
            this.teacher_student_tabPage.TabIndex = 0;
            this.teacher_student_tabPage.Text = "学生管理";
            this.teacher_student_tabPage.UseVisualStyleBackColor = true;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(34, 381);
            this.addStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(75, 32);
            this.addStudentBtn.TabIndex = 1;
            this.addStudentBtn.Text = "增加学生";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.teacher_student_tabPage);
            this.tabControl1.Controls.Add(this.tutor_score_tabPage);
            this.tabControl1.Controls.Add(this.Student_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(39, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.MaximumSize = new System.Drawing.Size(589, 444);
            this.tabControl1.MinimumSize = new System.Drawing.Size(589, 444);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 444);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreViewByStudent)).EndInit();
            this.Student_tabPage.ResumeLayout(false);
            this.tutor_score_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            this.teacher_student_tabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitBtn3;
        private System.Windows.Forms.Button updatePassWordBtn;
        private System.Windows.Forms.DataGridView scoreViewByStudent;
        private System.Windows.Forms.TabPage Student_tabPage;
        private System.Windows.Forms.Button selectCourseBtn;
        private System.Windows.Forms.TabPage tutor_score_tabPage;
        private System.Windows.Forms.Button QuitBtn2;
        private System.Windows.Forms.Button updateScoreBtn;
        private System.Windows.Forms.Button selectScoreBtn;
        private System.Windows.Forms.Button delScoreBtn;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.DataGridView StudentView;
        private System.Windows.Forms.Button selectStudentBtn;
        private System.Windows.Forms.Button delStudentBtn;
        private System.Windows.Forms.Button QuitBtn1;
        private System.Windows.Forms.Button updateStudentBtn;
        private System.Windows.Forms.TabPage teacher_student_tabPage;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.TabControl tabControl1;
    }
}