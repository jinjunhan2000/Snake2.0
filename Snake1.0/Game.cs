using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        int _Level = 1;//关卡等级
        int _MaxScore = 20;//分数上限
        int _count = 0;//食物个数
        int _Eatcount = 0;//被吃食物个数
        int _Score_Now = 10;//得分

        public int Level { get => _Level; set => _Level = value; }
        public int MaxScore { get => _MaxScore; set => _MaxScore = value; }
        public int Count { get => _count; set => _count = value; }
        public int Eatcount { get => _Eatcount; set => _Eatcount = value; }
        public int Score_Now { get => _Score_Now; set => _Score_Now = value; }
        public void LV_SET()
        {
            Eatcount = 0;
            Level = Level + 1;
            MaxScore = Level * 20;
        }
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
    }
}
