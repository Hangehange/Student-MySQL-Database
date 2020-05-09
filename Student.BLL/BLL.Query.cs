using System.Data;
using System.Windows.Forms;
using Student.DAL;
using Student.Model;


namespace Student.BLL
{
    public class Query
    {
        DataPool dataPool;//实例化DAL中主类，以实现BLL对DAL访问

        public Query()
        {
            dataPool = new DataPool();
        }

        public DataSet ShowAllUser()
        {
            string sql = "select * from userInfo order by u_id asc";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet ShowAllEtudiant()
        {
            string sql = "select * from userInfo where u_role = 'Student' ";//
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }   

        public DataSet ShowAllScore()
        {
            string sql = "select studentInfo.m_id, m_name, c_id, c_name, " +
                "score from studentInfo, student_course where studentInfo.m_id = student_course.m_id";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet SelectOneUser(string id)
        {
            string sql = "select * from userInfo where u_id = '" + id + "'";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet SelectOneEtudiantAndScore(string id)
        {
            string sql = "select studentInfo.m_id, m_name, c_id, c_name, " +
                "score from studentInfo, student_course where studentInfo.m_id = '"
                + id + "' and studentInfo.m_id = student_course.m_id";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet SelectByScore(string score)
        {
            string sql = "select studentInfo.m_id, m_name, c_id, c_name, score " +
                "from studentInfo,student_course where score = " + score 
                + " and studentInfo.m_id = student_course.m_id";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public bool IsUser(string id)
        {
            bool result = false;

            string sql = "select u_name from userInfo where u_id = '" + id + "'";
            try
            {
                DataSet dataSet = dataPool.GetData(sql, "user");
                if (dataSet.Tables[0].Rows[0][0].ToString().Trim() != "")
                    result = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("不能正确连接数据库!请检查DAL.Query中ConnectCommandString\n"
                    + ex.Message);
            }
            

            return result;
        }

        public bool AddEtudiant(User user)
        {
            bool result = false;
            bool insertUserInfoResult = false;
            bool insertetudiantInfoResult = false;
            bool insertCourseInfoResult = true;
            bool insertEtudiant_CourseInfoResult = false;

            string user_sql = "insert into userInfo " + "(u_id,u_name,u_password,u_role)" +
                " values('"+ user.id + "','" + user.name + "','"+ user.password + "','" + user.role + "')";
        
            if (dataPool.CommandExe(user_sql) == true)
                insertUserInfoResult = true;

            string etudiant_sql = "insert into studentinfo (m_id,m_name) values('"
                    + user.id + "','" + user.name + "')";

            if (dataPool.CommandExe(etudiant_sql) == true)
                insertetudiantInfoResult = true;

            string course_sql = "insert into courseInfo (c_id,c_name) values('0','001')";

            if (dataPool.CommandExe(course_sql) == true)
                insertCourseInfoResult = true;

            string etudiant_course_sql = "insert into student_course (m_id) values('"
                    + user.id + "')";

            if (dataPool.CommandExe(etudiant_course_sql) == true)
                insertEtudiant_CourseInfoResult = true;

            if (insertUserInfoResult && insertetudiantInfoResult &&
                insertCourseInfoResult && insertEtudiant_CourseInfoResult)
                result = true;

            return result;
        }

        public bool UpdateEtudiantInfo(User user)
        {
            bool result = false;
            bool updateUserInfoResult = false;
            bool updateEtudiantInfoResult = false;


            string user_sql = "update userInfo set u_name = '" + user.name +
                "',u_password = '" + user.password +
                "' where u_id = '" + user.id + "'";
            if (dataPool.CommandExe(user_sql) == true)
                updateUserInfoResult = true;

            string etudiant_sql = "update studentInfo set m_name = '" + user.name +
                "' where m_id = '" + user.id + "'";
            if (dataPool.CommandExe(etudiant_sql) == true)
                updateEtudiantInfoResult = true;

            if (updateUserInfoResult && updateEtudiantInfoResult)
                result = true;

            return result;
        }

        public bool DeleteEtudiantInfo(string id)
        {
            bool result = false;
            bool deleteEtudiantInfoResult = false;
            bool deleteUserResult = false;
            bool deleteEtudiant_CourseInfoResult = false;

            string etudiant_course_sql = "delete from student_course where m_id = " + id  ;
            if (dataPool.CommandExe(etudiant_course_sql) == true)
                deleteEtudiant_CourseInfoResult = true;

            string etudiant_sql = "delete from studentInfo where m_Id = " + id  ;
            if (dataPool.CommandExe(etudiant_sql) == true)
                deleteEtudiantInfoResult = true;

            string user_sql = "delete from userInfo where u_id = '" + id + "'"  ;
            if (dataPool.CommandExe(user_sql) == true)
                deleteUserResult = true;

            if (deleteUserResult && deleteEtudiantInfoResult && deleteEtudiant_CourseInfoResult)
                result = true;
            return result;
        }

        public bool DeleteScore(string id)
        {
            bool result = false;

            string sql = "update student_course set c_id = '0', c_name = '0', score = 0" +
                " where m_id = '" + id + "'";
            if (dataPool.CommandExe(sql) == true)
                result = true;

            return result;
        }

        public bool ADDScoreInfo(Etudiant etudiant)
        {
            bool result = false;
            //bug
            bool updateCourseInfoResult = true;
            bool updateEtudiant_CourseInfoResult = false;

            string etudiant_course_sql = "update student_course set c_id = '" + etudiant.id +
                "',c_name = '" + etudiant.name +
                "',score = " + etudiant.score +
                " where m_id = '" + etudiant.id + "'";
            if (dataPool.CommandExe(etudiant_course_sql) == true)
                updateEtudiant_CourseInfoResult = true;

            if (updateCourseInfoResult && updateEtudiant_CourseInfoResult)
                result = true;

            return result;
        }

        public bool UpdateScoreInfo(Etudiant etudiant)
        {
            bool result = false;
            //bug
            bool updateCourseInfoResult = true;
            bool updateEtudiant_CourseInfoResult = false;


            //string user_sql = "update courseInfo set c_id = '" + etudiant.c_id +
            //    "',c_name = '" + etudiant.c_name +
            //    "' where u_id = '" + user.id + "'";
            //if (dataPool.CommandExe(user_sql) == true)
            //    updateUserInfoResult = true;

            string etudiant_course_sql = "update student_course set score = " + etudiant.score +
                " where m_id = '" + etudiant.id + "'";
            if (dataPool.CommandExe(etudiant_course_sql) == true)
                updateEtudiant_CourseInfoResult = true;

            if (updateCourseInfoResult && updateEtudiant_CourseInfoResult)
                result = true;

            return result;
        }

        public bool UpdatePassword(string id, string password)
        {
            bool result = false;

            string sql = "update userInfo set u_password = '" + password +
                "' where u_id = '" + id + "'";
            if (dataPool.CommandExe(sql) == true)
                result = true;

            return result;
        }

    }

}
