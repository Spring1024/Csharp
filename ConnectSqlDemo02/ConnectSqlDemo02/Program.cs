using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectSqlDemo02
{
    class Program
    {
        
        private static void LinkSqlSrv(string sqlSrv, string sqlName, string logisUser, string loginpwd)
        {
            string connstr = GetConnstr(sqlSrv, sqlName, logisUser, loginpwd);
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = connstr;
            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("数据库连接失败！请检查配置文件信息！" + e.Message);
                Console.WriteLine(connstr);
                return;
            }
            if (sqlConn.State == System.Data.ConnectionState.Open)
                Console.WriteLine("数据库连接成功！当前信息为：");
            else
                Console.WriteLine("数据库连接失败！当前信息为：");
            Console.WriteLine("————————————————————");
            Console.WriteLine("数据库服务器：" + sqlConn.DataSource);
            Console.WriteLine("登录的数据库名：" + sqlConn.Database);
            Console.WriteLine("登录名：" + logisUser);
            Console.WriteLine("密码：" + loginpwd);
            Console.WriteLine("————————————————————");
            string sqlStr = "select * from Table_Czy";
            SqlCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = sqlStr;
            SqlDataReader sdr = sqlCmd.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write("{0,-10}\t", sdr.GetName(i).Trim());//输出字段名列表，{0,-10}表示输出内容时占用10字符位置，左对齐输出，以TAB字符分隔各字段
            }
 
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write("{0,-10}\t", sdr[i]);//输出字段内容
                    //Console.Write("{0}\t", sdr.GetValue(i));//与上一语句等价
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            sqlConn.Close();
            return;
        }

        private static string GetConnstr(string datesource, string datebase, string logisUser, string loginpwd)
        {
            return "Data Source=" + datesource + ";Initial Catalog=" + datebase + ";Persist Security Info=True;User ID=" + logisUser + ";Password=" + loginpwd;
        }
        static void Main(string[] args)
        {
            string dbsvr=@"(local)\sqlexpress";
             string dbName = "xscj_db";         //数据库名称
            string loginUser = "sa";       //登录名
            string loginPwd = "woaiwo992"; 
            LinkSqlSrv(dbsvr,dbName,loginUser,loginPwd);
            
            Console.ReadKey();
        }
    }
}
