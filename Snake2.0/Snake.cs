using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Snake
    {
        int _directionX=20, _directionY=0;
        int _length = 3;//当前蛇身长度
        int _speed = 1000;//速度(数值越小，越快）
        PictureBox[] _PB = new PictureBox[100];
        PictureBox _pir = new PictureBox();//食物

        public int DirectionX { get => _directionX; set => _directionX = value; }
        public int DirectionY { get => _directionY; set => _directionY = value; }
        public int Length { get => _length; set => _length = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public PictureBox[] PB { get => _PB; set => _PB = value; }
        public PictureBox Pir { get => _pir; set => _pir = value; }

        public void Init(Label LV,Button start,PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3,Game game)
        {
            LV.Text = "第" + game.Level.ToString() + "关";
            start.Text = "开始游戏";
            PB[0] = pictureBox1;
            PB[1] = pictureBox2;
            PB[2] = pictureBox3;
        }
        public void Key_Up()
        {
            DirectionX = 0;
            DirectionY = -20;
        }
        public void Key_Down()
        {
            DirectionX = 0;
            DirectionY = 20;
        }
        public void Key_Left()
        {
            DirectionX = -20;
            DirectionY = 0;
        }
        public void Key_Right()
        {
            DirectionX = 20;
            DirectionY = 0;
        }
        public void SnakeMove(PictureBox pictureBox1)//p
        {      
            for (int i = Length - 1; i > 0; i--)
                PB[i].Location = PB[i - 1].Location;
            pictureBox1.Location = new Point(pictureBox1.Location.X + DirectionX, pictureBox1.Location.Y + DirectionY);
        }
        public void Eat(play play,Game game,Label score)//p
        {
            if (PB[0].Location == Pir.Location)
            {
                PictureBox p = new PictureBox();
                p.Size = new Size(20, 20);
                int X = PB[Length - 1].Location.X - PB[Length - 2].Location.X;
                int Y = PB[Length - 1].Location.Y - PB[Length - 2].Location.Y;
                p.Location = new Point(PB[Length - 1].Location.X + X, PB[Length - 1].Location.Y + Y);
                long tick = DateTime.Now.Ticks;
                Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                int R = ran.Next(255);
                int G = ran.Next(255);
                int B = ran.Next(255);
                p.BackColor = Color.FromArgb(R, G, B);
                play.Controls.Add(p);
                PB[Length++] = p;
                game.Count = 0;
                game.Score_Set();
                score.Text = (game.Eatcount * game.Score_Now).ToString();
            }
        }
    }
}
