using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Snake
{
    public partial class play : Form
    {
        public Snake snake;
        public Game game;
        Database db = new Database();
        //事件
        public play()//y
        {
            InitializeComponent();
            db.Username= login.username;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)//wy
        {
            game.Key_Changed(snake,e);
        }
        private void timer1_Tick(object sender, EventArgs e)//wy
        {
            timer1.Interval = snake.Speed;
            game.Close_Error(snake, snake.PB, db, timer1, score, this);
            snake.SnakeMove(pictureBox1); 
            snake.Eat(this,game,score);
            if (game.Count == 0&& game.Eatcount * game.Score_Now != game.MaxScore)
                game.New_Food(snake.Pir,snake,snake.PB,this);
            if (game.Eatcount * game.Score_Now==game.MaxScore)
                 game.LV_SET(timer1,score, db, this, snake, game);
        }
        private void Form1_Load(object sender, EventArgs e)//w
        {
            snake.Init(LV, start,pictureBox1, pictureBox2, pictureBox3, game);
        }
        private void start_Click_1(object sender, EventArgs e)//w
        {
            timer1.Enabled = true;
            game.Music_Set();
        }
        private void pause_Click(object sender, EventArgs e)//w
        {
            timer1.Enabled = false;
            start.Text = "继续游戏";
            SoundPlayer sp = new SoundPlayer("Dreamland.wav");//必须是带.wav扩展名的音频文件
            sp.PlayLooping();//循环播放
        }
        private void RETURN_Click(object sender, EventArgs e)//w
        {
            this.timer1.Stop();
            this.Controls.Clear();
            menu menu = new menu() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(menu);
            menu.Show();
        }
    }
}
