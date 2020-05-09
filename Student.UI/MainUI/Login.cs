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

namespace Student.UI
{
    public partial class 登录系统 : Form
    {
        public string id;

        private string password;

        public string select;

        private DataSet dataSet;

        Query query = new Query();

        public 登录系统()
        {
            InitializeComponent();
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            if (userID_input.TextLength == 0 || password_input.TextLength == 0)
            {
                MessageBox.Show("你有未填写的信息", "提示：",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = userID_input.Text.Trim().ToString();
            password = password_input.Text.Trim().ToString();

            if (admin_select.Checked)
            {
                select = "Teacher";
            }
            else if (student_select.Checked)
            {

                select = "Student";
            }
            else
            {
                MessageBox.Show("你未选择你的角色！", "提示：", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  

            if (query.IsUser(id))
            {
                dataSet = query.SelectOneUser(id);
                string getID = dataSet.Tables[0].Rows[0][0].ToString().Trim();
                string getPassWord = dataSet.Tables[0].Rows[0][2].ToString().Trim();
                string getRole = dataSet.Tables[0].Rows[0][3].ToString().Trim();

                if (id == getID)
                {
                    if (password == getPassWord)
                    {
                        if (select == getRole)
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("角色错误\n请重输入", "温馨提示：",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("密码错误\n请重输入", "温馨提示：", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("ID错误\n请重输入", "温馨提示：", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void admin_select_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 登录系统_Load(object sender, EventArgs e)
        {

        }
    }
}
