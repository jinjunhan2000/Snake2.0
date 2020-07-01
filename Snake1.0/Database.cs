using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Snake
{
    class Database
    {
        string _username;
        string _password;
        int _score;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int Score { get => _score; set => _score = value; }


        public Database() { }
        public Database(string username, string password)
        {
            this._username = username;
            this._password = password;
        }
        //注册时查找用户名是否已经存在
        public bool Select_Name()
        {
            string sql = "select username from userlogin where username ='" + Username + "'";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                dr.Close();
                SqlHelper.Close();
                return true;
            }
            SqlHelper.Close();
            return false;
        }
        //登陆时查找用户名密码是否正确
        public bool Select_User()
        {
            string sql = "select username from userlogin where username ='" + Username + "' and password='" + Password + "'";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                dr.Close();
                SqlHelper.Close();
                return true;
            }
            SqlHelper.Close();
            return false;
        }
        //注册后的信息传入数据库
        public void Insert()
        {
            string sql = string.Format("insert into userlogin(username,password,score) values('{0}','{1}','0')", Username, Password);
            SqlHelper.ExecuteSql(sql);
        }
        //更新分数
        public void Update()
        {
            string sql = "update userlogin set score='" + Score + "'where username='" + Username + "'";
            SqlHelper.ExecuteSql(sql);
        }
        //分数传入数据库
        public void Update_Score(int score)
        {
            Score = score;
            Update();
        }
    }
}
