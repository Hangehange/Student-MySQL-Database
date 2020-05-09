using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.DAL
{
    public class DataPool
    {
        String ConnectCommandString =
            "server = localhost; " +
            "port=3306;" + 
            "user=root;" +
            "password=123456;" +
            "database=hangedb";//如果需要，可改云数据库

        MySqlCommand command;

        MySqlConnection mySqlConnection;

        MySqlDataAdapter adapter;

        DataSet dataSet;

        public bool CommandExe(string comm)//判断SQL语句执行结果
        {
            bool result = false;
            int i;
            mySqlConnection = new MySqlConnection(ConnectCommandString);
            command = new MySqlCommand(comm, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                i = command.ExecuteNonQuery();
                mySqlConnection.Close();
                if (i > 0)
                    result = true;              
            }
            catch (Exception ex)
            {
                MessageBox.Show("不能正确连接数据库!请检查DAL.Query中ConnectCommandString\n" 
                    + ex.Message);
            }
            return result;

        }


        public DataSet GetData(string sql, string tableName)//返回SQL查询结果的表
        {
            try
            {
                mySqlConnection = new MySqlConnection(ConnectCommandString);
                command = new MySqlCommand(sql, mySqlConnection);
                adapter = new MySqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (mySqlConnection != null)
                    mySqlConnection.Close();
            }
            return dataSet;
        }
    }
}

