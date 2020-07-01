using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Snake
{
    public partial class login : Form
    {
        public static string username;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            LBusername.Parent = LBbackground;
            LBpassword.Parent = LBbackground;
            BTlogin.Parent = LBbackground;
            BTregister.Parent = LBbackground;
            LBgamename.Parent = LBbackground;
            SoundPlayer sp = new SoundPlayer("Dreamland.wav");//必须是带.wav扩展名的音频文件
            sp.PlayLooping();//循环播放
        }
        private void BTlogin_Click(object sender, EventArgs e)
        {
            Database db = new Database(TBusername.Text.ToString(), TBpassword.Text.ToString());
            bool select = db.Select_User();
            if (select == true)
            {
                username = TBusername.Text.ToString();
                this.Controls.Clear();
                menu menu = new menu() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.Controls.Add(menu);
                menu.Show();
            }
            else
                MessageBox.Show("用户名或密码错误！");
        }

        private void BTregister_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            register register = new register() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(register);
            register.Show();
        }
    }
}
