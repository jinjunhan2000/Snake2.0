using System;
using System.Collections.Generic;
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
        

        public int DirectionX { get => _directionX; set => _directionX = value; }
        public int DirectionY { get => _directionY; set => _directionY = value; }
        public int Length { get => _length; set => _length = value; }
        public int Speed { get => _speed; set => _speed = value; }      
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
    }
}
