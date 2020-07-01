using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Snake
{
    public class Game
    {
        int _Level = 1;//关卡等级
        int _MaxScore = 20;//分数上限
        int _count = 0;//食物个数，控制生成食物0生成，1不生成
        int _Eatcount = 0;//被吃食物个数
        int _Score_Now = 10;//得分

        public int Level { get => _Level; set => _Level = value; }
        public int MaxScore { get => _MaxScore; set => _MaxScore = value; }
        public int Count { get => _count; set => _count = value; }
        public int Eatcount { get => _Eatcount; set => _Eatcount = value; }
        public int Score_Now { get => _Score_Now; set => _Score_Now = value; }
        public void Score_Set()
        {
            Eatcount++;            
        }
        public void Music_Set()
        {
            SoundPlayer sp;
            if (Level == 1)
            {
                sp = new SoundPlayer("Candlelight.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 2)
            {
                sp = new SoundPlayer("Darkgirl.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 3)
            {
                sp = new SoundPlayer("TheRhythmofice.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 4)
            {
                sp = new SoundPlayer("adare.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 5)
            {
                sp = new SoundPlayer("Eastcastle.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 6)
            {
                sp = new SoundPlayer("Kongfustorm.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 7)
            {
                sp = new SoundPlayer("Library.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 8)
            {
                sp = new SoundPlayer("devil.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 9)
            {
                sp = new SoundPlayer("time.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
            if (Level == 10)
            {
                sp = new SoundPlayer("tower.wav");//必须是带.wav扩展名的音频文件
                sp.PlayLooping();//循环播放
            }
        }     
        public void LV_SET(Timer timer1, Label score,Database db,play play,Snake snake,Game game)//h下一关
        {
            timer1.Stop();
            db.Update_Score(int.Parse(score.Text.ToString()));//分数
            if (Level != 10)
            {
                MessageBox.Show("点击进入下一关");
                play.Controls.Clear();
                play play_new = new play() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                play_new.snake = new Snake();
                play_new.snake.Speed = snake.Speed - 80;
                play_new.game = game;
                Eatcount = 0;
                Level = Level + 1;
                MaxScore = Level * 20;
                play.Controls.Add(play_new);
                play_new.Show();
            }
            else
                MessageBox.Show("恭喜通关");
        }
        public void New_Game(Timer timer1, play play)//h返回第一关
        {
            timer1.Stop();
            play.Controls.Clear();
            play play_new = new play() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            play_new.snake = new Snake();
            play_new.game = new Game();
            play.Controls.Add(play_new);
            play_new.Show();
        }
        public void New_Food(PictureBox pir,Snake snake, PictureBox[] PB,play play)//3生成食物
        {
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            int R = ran.Next(255);
            int G = ran.Next(255);
            int B = ran.Next(255);
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
                if (i == snake.Length)
                    break;
            }
            play.Controls.Add(pir);
            Count = 1;
        }
        public void Close_Error(Snake snake, PictureBox[] PB, Database db,Timer timer1,Label score,play play)//y错误逻辑
        {
            if (PB[0].Location.X + snake.DirectionX > 299 || PB[0].Location.X + snake.DirectionX < 0 || PB[0].Location.Y + snake.DirectionY > 259 || PB[0].Location.Y + snake.DirectionY < 0)
            {
                timer1.Stop();
                db.Update_Score(int.Parse(score.Text.ToString()));//分数
                MessageBox.Show("游戏结束，请重新开始");
                New_Game(timer1,play);
            }
            for (int i = 1; i < snake.Length; i++)
            {
                if (PB[0].Location.X + snake.DirectionX == PB[i].Location.X && PB[0].Location.Y + snake.DirectionY == PB[i].Location.Y)
                {
                    timer1.Stop();
                    db.Update_Score(int.Parse(score.Text.ToString()));//分数
                    MessageBox.Show("游戏结束，请重新开始");
                    New_Game(timer1, play);
                }
            }
        }
        public void Key_Changed(Snake snake, KeyEventArgs e)
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
    }
}
