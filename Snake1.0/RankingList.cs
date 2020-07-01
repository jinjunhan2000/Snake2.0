using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Snake
{
    public partial class RankingList : Form
    {
        public RankingList()
        {
            InitializeComponent();
        }

        private void RankingList_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = SqlHelper.ExecuteReader("select username,score from userlogin order by score DESC ");
            int i=1;
            while (dr.Read())
            {
                RankingList_Txt.Text += string.Format ("    {0}",i++)+"\t\t"+ dr["username"].ToString()+"\t"+dr["score"].ToString()+ "\r\n";
            }
            dr.Close();
            SqlHelper. Close();
        }

        private void RankingList_BT_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            menu menu = new menu() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(menu);
            menu.Show();
        }

    }
}
