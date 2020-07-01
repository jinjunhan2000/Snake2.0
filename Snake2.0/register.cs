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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            Register_LB_username.Parent = Register_LB_background;
            Register_LB_password.Parent = Register_LB_background;
            Register_BT_register.Parent = Register_LB_background;
            Register_BT_login.Parent = Register_LB_background;
            SoundPlayer sp = new SoundPlayer("Dreamland.wav");//必须是带.wav扩展名的音频文件
            sp.PlayLooping();//循环播放
        }

        private void Register_BT_login_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            login login = new login() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(login);
            login.Show();
        }

        private void Register_BT_register_Click(object sender, EventArgs e)
        {
            Database db = new Database(Register_TB_username.Text.ToString(), Register_TB_password.Text.ToString());
            bool select = db.Select_Name();
            if (select == false)
            {
                if (Register_TB_password.Text.ToString() == Register_TB_password2.Text.ToString())
                {
                    db.Insert();
                    MessageBox.Show("注册成功。");
                    Register_BT_login_Click(this, new EventArgs());
                }
                else
                    MessageBox.Show("请输入一致的密码。");

            }
            else
                MessageBox.Show("用户名已经存在，请重新注册。");
        }
    }
}
