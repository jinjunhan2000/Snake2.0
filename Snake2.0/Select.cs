using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        private void Game_Set(int level)//w
        {
            Snake snake = new Snake();
            Game game = new Game();
            game.Level = level;
            this.Controls.Clear();
            play play = new play() { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            play.game = game;
            play.snake = snake;
            game.MaxScore = game.Level * 20;
            snake.Speed = 1000 - 80 * (game.Level - 1);
            this.Controls.Add(play);
            play.Show();
        }
        private void Select_1_Click(object sender, EventArgs e)
        {
            Game_Set(1);
        }

        private void Select_2_Click(object sender, EventArgs e)
        {
            Game_Set(2);
        }

        private void Select_3_Click(object sender, EventArgs e)
        {
            Game_Set(3);
        }

        private void Select_4_Click(object sender, EventArgs e)
        {
            Game_Set(4);
        }

        private void Select_5_Click(object sender, EventArgs e)
        {
            Game_Set(5);
        }

        private void Select_6_Click(object sender, EventArgs e)
        {
            Game_Set(6);
        }

        private void Select_7_Click(object sender, EventArgs e)
        {
            Game_Set(7);
        }

        private void Select_8_Click(object sender, EventArgs e)
        {
            Game_Set(8);
        }

        private void Select_9_Click(object sender, EventArgs e)
        {
            Game_Set(9);
        }

        private void Select_10_Click(object sender, EventArgs e)
        {
            Game_Set(10);
        }
    }
}
