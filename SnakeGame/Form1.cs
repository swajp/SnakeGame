using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        PictureBox snakeOne;
        List<PictureBox> tailSnake;
        PictureBox snakeTwo;
        double direction1;
        double speed1;

        Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            CreateSnakes();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                direction1 += 0.1;
            }
            else if (e.KeyCode == Keys.D)
            {
                direction1 -= 0.1;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tailSnake.Add(snakeOne);
            snakeOne = new PictureBox();
            snakeOne.Size = new Size(13, 13);
            var changeX = speed1 * Math.Cos(direction1);
            var changeY = speed1 * -Math.Sin(direction1);
            snakeOne.Location = new Point(tailSnake.Last().Location.X + (int)changeX, tailSnake.Last().Location.Y + (int)changeY);
            snakeOne.BackColor = Color.Red;
            Controls.Add(snakeOne);
        }

        private void CreateSnakes()
        {
            tailSnake = new List<PictureBox>();
            direction1 = 0;
            speed1 = 2;
            snakeOne = new PictureBox();
            snakeOne.Size = new Size(13,13);
            snakeOne.Location = new Point(10,10);
            snakeOne.BackColor = Color.Red;
            Controls.Add(snakeOne);
            
            snakeTwo = new PictureBox();
            snakeTwo.Size = new Size(13, 13);
            snakeTwo.Location = new Point(ClientSize.Width-60, 10);
            snakeTwo.BackColor = Color.Blue;
            Controls.Add(snakeTwo);
        }

    }
}
