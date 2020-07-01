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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            Menu_gamename.Parent = Menu_background;
            Menu_start.Parent = Menu_background;
            Menu_select.Parent = Menu_background;
            Menu_RankingList.Parent = Menu_background;
            Menu_exit.Parent = Menu_background;
            SoundPlayer sp = new SoundPlayer("Dreamland.wav");//必须是带.wav扩展名的音频文件
            sp.PlayLooping();//循环播放
        }

        private void Menu_start_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            play play = new play() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            play.snake = new Snake();
            play.game = new Game();
            this.Controls.Add(play);
            play.Show();
        }

        private void Menu_select_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Select select = new Select() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(select);
            select.Show();
        }

        private void Menu_RankingList_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            RankingList rankingList = new RankingList() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(rankingList);
            rankingList.Show();
        }

        private void Menu_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
