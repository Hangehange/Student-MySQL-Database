using Student.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.UI.SubDlgs;
using Student.UI.score;

namespace Student.UI.student
{
    public partial class MainUI : Form
    {
        
        private Query query;//实现对BLL层

        private string id;

        private string select;

        private DataSet userDataSet;

        private DataSet scoreDataSet;

        public MainUI(string id, string select)
        {
            InitializeComponent();
            this.id = id;
            this.select = select;
            if (this.select == "Teacher")
            {
                this.Text = "学生成绩管理系统--教师端";
                Student_tabPage.Dispose();
                UpdateStudentView();
                UpdateScoreView();
            }
            else if (this.select == "Student")
            {
                this.Text = "学生成绩管理系统--学生端";
                teacher_student_tabPage.Dispose();
                tutor_score_tabPage.Dispose();
                UpdateScoreViewByStudent();
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void UpdateStudentView()
        {
            query = new Query();
            userDataSet = query.ShowAllEtudiant();
            StudentView.DataSource = userDataSet.Tables[0];
            StudentView.Columns[0].HeaderCell.Value = "编号";
            StudentView.Columns[1].HeaderCell.Value = "姓名";
            StudentView.Columns[2].HeaderCell.Value = "密码";
            StudentView.Columns[3].HeaderCell.Value = "角色";
        }

        private void UpdateScoreView()
        {
            query = new Query();
            scoreDataSet = query.ShowAllScore();
            scoreView.DataSource = scoreDataSet.Tables[0];
            scoreView.Columns[0].HeaderCell.Value = "学号";
            scoreView.Columns[1].HeaderCell.Value = "姓名";
            scoreView.Columns[2].HeaderCell.Value = "课程号";
            scoreView.Columns[3].HeaderCell.Value = "课程名";
            scoreView.Columns[4].HeaderCell.Value = "成绩";
        }

        private void UpdateScoreViewByStudent()
        {
            query = new Query();
            scoreDataSet = query.SelectOneEtudiantAndScore(id);
            scoreViewByStudent.DataSource = scoreDataSet.Tables[0];
            scoreViewByStudent.Columns[0].HeaderCell.Value = "学号";
            scoreViewByStudent.Columns[1].HeaderCell.Value = "姓名";
            scoreViewByStudent.Columns[2].HeaderCell.Value = "课程号";
            scoreViewByStudent.Columns[3].HeaderCell.Value = "课程名";
            scoreViewByStudent.Columns[4].HeaderCell.Value = "成绩";
        }

        private void Find(string id)
        {
            DataSet dataSet = query.SelectOneUser(id);
            if (dataSet.Tables[0].Rows.Count == 0)
                MessageBox.Show("抱歉，没有找到该生的信息!", "温馨提示：", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            StudentView.DataSource = dataSet.Tables[0];
        }

        private void FindScore(string id)
        {
            DataSet dataSet = query.SelectByScore(id);
            if (dataSet.Tables[0].Rows.Count == 0)
                MessageBox.Show("抱歉，没有找到该生的信息!", "温馨提示：",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            scoreView.DataSource = dataSet.Tables[0];
        }

        /*------------------点击事件响应----------------------------*/

        private void QuitBtn1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void QuitBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuitBtn3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudentBtn_Click_1(object sender, EventArgs e)
        {
            AddStudentDlg addMaster = new AddStudentDlg();
            addMaster.ShowDialog();
            UpdateStudentView();
            UpdateScoreView();
        }

        private void DelStudentBtn_Click_1(object sender, EventArgs e)
        {
            string id = null;
            try
            {
                id = StudentView.CurrentRow.Cells[0].Value.ToString();
                if (query.DeleteEtudiantInfo(id) == true)
                {
                    MessageBox.Show("该生的记录已经删除！", "温馨提示：",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateStudentView();
                    UpdateScoreView();
                }
                else return;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("已然没学生了还想删谁啊！", "没得删了",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
            
        }

        private void SelectStudentBtn_Click_1(object sender, EventArgs e)
        {
            SelectStudentDlg selectMasterDlg = new SelectStudentDlg();
            selectMasterDlg.MyEvent += new MyDelegate(Find);
            selectMasterDlg.Show();
        }
           
        private void UpdateStudentBtn_Click_1(object sender, EventArgs e)
        {
            string id = null;
            try
            {
                id = StudentView.CurrentRow.Cells[0].Value.ToString();
                UpdateStudentDlg addMaster = new UpdateStudentDlg(id);
                addMaster.ShowDialog();
                UpdateStudentView();
                UpdateScoreView();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("没得学生，谁也改不了！", "没得改了",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

           
           
        }

        private void AddScoreBtn_Click_1(object sender, EventArgs e)
        {
            string id = scoreView.CurrentRow.Cells[0].Value.ToString();
            AddScoreDlg addScoreDlg = new AddScoreDlg(id);
            addScoreDlg.ShowDialog();

            UpdateScoreView();
        }

        private void DelScoreBtn_Click_1(object sender, EventArgs e)
        {
            string id = scoreView.CurrentRow.Cells[0].Value.ToString();

            if (query.DeleteScore(id) == true)
            {
                MessageBox.Show("该生的记录已经删除！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //更新
                UpdateScoreView();
            }
            else return;
        }

        private void SelectScoreBtn_Click_1(object sender, EventArgs e)
        {
            SelecetScoreDlg selectScoreDlg = new SelecetScoreDlg();
            selectScoreDlg.MyEvent += new MyScoreDelegate(FindScore);
            selectScoreDlg.Show();

            UpdateScoreView();
        }

        private void UpdateScoreBtn_Click_1(object sender, EventArgs e)
        {
            string id = scoreView.CurrentRow.Cells[0].Value.ToString();
            UpdateScoreDlg updateScoreDlg = new UpdateScoreDlg(id);
            updateScoreDlg.ShowDialog();

            UpdateScoreView();
        }

        private void SelectCourseBtn_Click_1(object sender, EventArgs e)
        {
            UpdateScoreViewByStudent();
        }

        private void UpdatePassWordBtn_Click_1(object sender, EventArgs e)
        {
            UpdatePasswordDlg updatePasswordDlg = new UpdatePasswordDlg(id);
            updatePasswordDlg.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void student_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void scoreViewByStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
