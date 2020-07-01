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
        PictureBox[] PB = new PictureBox[100];
        PictureBox pir = new PictureBox();//食物

        Database db = new Database();
        //自定义函数
        private void New_Game()
        {
            timer1.Stop();
            this.Controls.Clear();
            play play = new play() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            play.snake = new Snake();
            play.game = new Game();
            game.LV_SET();
            this.Controls.Add(play);
            play.Show();
        }
        private void LV_SET()
        {
            timer1.Stop();
            db.Update_Score(int.Parse(score.Text.ToString()));//分数
            MessageBox.Show("点击进入下一关");                     
            this.Controls.Clear();
            play play = new play() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            play.snake = new Snake();
            play.snake.Speed =snake.Speed - 80;
            play.game = game;
            game.LV_SET();
            this.Controls.Add(play);
            play.Show();       
        }
        private void SnakeMove()
        {
            for (int i = snake.Length - 1; i > 0; i--)
                PB[i].Location = PB[i - 1].Location;
            pictureBox1.Location = new Point(pictureBox1.Location.X + snake.DirectionX, pictureBox1.Location.Y + snake.DirectionY);
        }
        private void New_Food()
        {
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            int R = ran.Next(255);
            int G = ran.Next(255);
            int B = ran.Next(255);
            B = (R + G > 400) ? R + G - 400 : B;//0 : 380 - R - G;
            B = (B > 255) ? 255 : B;
            pir.Size = new Size(20, 20);
            pir.BackColor = Color.FromArgb(R, G, B);
            Random R2 = new Random();
            int i = 0;
            while (true)
            {
                int X = R2.Next(15);
                int Y = R2.Next(13);
                pir.Location = new Point(X * 20, Y * 20);
                for (i = 0; i < snake.Length; i++)
                    if (PB[i].Location == pir.Location)
                        break;
                if(i== snake.Length)
                    break;
            }
            this.Controls.Add(pir);
            game.Count = 1;
        }
        private void Score_Set()
        {
            game.Score_Set();
            score.Text = (game.Eatcount * game.Score_Now).ToString();
        }
        private void Eat()
        {
            if (PB[0].Location == pir.Location)
            {
                PictureBox p = new PictureBox();
                p.Size = new Size(20, 20);
                int X = PB[snake.Length - 1].Location.X - PB[snake.Length - 2].Location.X;
                int Y = PB[snake.Length - 1].Location.Y - PB[snake.Length - 2].Location.Y;
                p.Location = new Point(PB[snake.Length - 1].Location.X+ X, PB[snake.Length - 1].Location.Y+ Y);               
                long tick = DateTime.Now.Ticks;
                Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                int R = ran.Next(255);
                int G = ran.Next(255);
                int B = ran.Next(255);
                B = (R + G > 400) ? R + G - 400 : B;//0 : 380 - R - G;
                B = (B > 255) ? 255 : B;
                p.BackColor = Color.FromArgb(R, G, B);
                this.Controls.Add(p);
                PB[snake.Length++] = p;
                game.Count = 0;
                Score_Set();
            }
        }
        private void Close_Error()
        {
            if (PB[0].Location.X + snake.DirectionX> 299|| PB[0].Location.X + snake.DirectionX<0|| PB[0].Location.Y + snake.DirectionY>259||PB[0].Location.Y + snake.DirectionY <0)
            {
                timer1.Stop();
                db.Update_Score(int.Parse(score.Text.ToString()));//分数
                MessageBox.Show("游戏结束，请重新开始");
                New_Game();
            }
            for (int i = 1; i < snake.Length; i++)
            {
                if (PB[0].Location.X + snake.DirectionX == PB[i].Location.X&& PB[0].Location.Y + snake.DirectionY == PB[i].Location.Y)
                {
                    timer1.Stop();
                    db.Update_Score(int.Parse(score.Text.ToString()));//分数
                    MessageBox.Show("游戏结束，请重新开始");
                    New_Game();
                }
            }
        }
        //事件
        public play()
        {
            InitializeComponent();
            db.Username= login.username;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (snake.DirectionY != 20)//如果正在往下,，则不能按上
            {
                if (e.KeyCode == Keys.Up)//上键
                    snake.Key_Up();
            }
            if (snake.DirectionY != -20)//如果正在往上，则不能按下
            {
                if (e.KeyCode == Keys.Down)//下键
                    snake.Key_Down();
            }
            if (snake.DirectionX != 20)//如果正在往右，则不能按左
            {
                if (e.KeyValue == 37)//左键
                    snake.Key_Left();
            }
            if (snake.DirectionX != -20)//如果正在往左，则不能按右
            {
                if (e.KeyValue == 39)//右键        
                    snake.Key_Right();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = snake.Speed;
            Close_Error();
            SnakeMove(); 
            Eat();
            if (game.Count == 0&& game.Eatcount * game.Score_Now != game.MaxScore)
                New_Food();
            if (game.Eatcount * game.Score_Now==game.MaxScore)
                 LV_SET();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LV.Text = "第" + game.Level.ToString() + "关";
            start.Text = "开始游戏";
            PB[0] = pictureBox1;
            PB[1] = pictureBox2;
            PB[2] = pictureBox3;   
        }
        private void start_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            game.Music_Set();
        }
        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            start.Text = "继续游戏";
            SoundPlayer sp = new SoundPlayer("Dreamland.wav");//必须是带.wav扩展名的音频文件
            sp.PlayLooping();//循环播放
        }
        private void RETURN_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Controls.Clear();
            menu menu = new menu() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.Controls.Add(menu);
            menu.Show();
        }
    }
}
