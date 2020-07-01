using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Snake
{
    class SqlHelper
    {
        //创建连接字符串
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConectionString"];
        //创建连接对象
        public static SqlConnection conn = new SqlConnection();
        /// <summary>
        /// 打开数据库连接，成功返回true，失败返回false
        /// </summary>
        /// <returns></returns>
        public static bool Open()
        {
            //连接属性赋值
            conn.ConnectionString = connectionString;
            //尝试打开连接
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public static SqlDataReader ExecuteReader(string sql)
        {
            ////打开数据库连接
            Open();
            //创建Commend对象
            SqlCommand command = new SqlCommand();
            command.Connection = SqlHelper.conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            //执行查询
            SqlDataReader dr = command.ExecuteReader();
            return dr;
        }
        public static void ExecuteSql(string sql)
        {
            Open();
            SqlCommand command = new SqlCommand();
            command.Connection = SqlHelper.conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            Close();
        }
    }
}
