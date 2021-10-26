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
        List<PictureBox> tailSnake1;
        double direction1;
        double speed1;
        bool a;
        bool d;

        PictureBox snakeTwo;
        List<PictureBox> tailSnake2;
        double direction2;
        double speed2;
        bool left;
        bool right;

        Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
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
                a = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                d = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                a = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                d = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (a)
            {
                direction1 += 0.4;
            }
            if (d)
            {
                direction1 -= 0.4;
            }
            if (left)
            {
                direction2 += 0.4;
            }
            if (right)
            {
                direction2 -= 0.4;
            }

            tailSnake1.Add(snakeOne);
            snakeOne = new PictureBox();
            snakeOne.Size = new Size(13, 13);
            var changeX = speed1 * Math.Cos(direction1);
            var changeY = speed1 * -Math.Sin(direction1);
            snakeOne.Location = new Point(tailSnake1.Last().Location.X + (int)changeX, tailSnake1.Last().Location.Y + (int)changeY);
            snakeOne.BackColor = Color.Red;
            Controls.Add(snakeOne);

            tailSnake2.Add(snakeTwo);
            snakeTwo = new PictureBox();
            snakeTwo.Size = new Size(13, 13);
            var changeX2 = speed2 * Math.Cos(direction2);
            var changeY2 = speed2 * -Math.Sin(direction2);
            snakeTwo.Location = new Point(tailSnake2.Last().Location.X + (int)changeX2, tailSnake2.Last().Location.Y + (int)changeY2);
            snakeTwo.BackColor = Color.Blue;
            Controls.Add(snakeTwo);
        }

        private void CreateSnakes()
        {
            tailSnake1 = new List<PictureBox>();
            direction1 = 0;
            speed1 = 2.3;
            snakeOne = new PictureBox();
            snakeOne.Size = new Size(13,13);
            snakeOne.Location = new Point(10,10);
            snakeOne.BackColor = Color.Red;
            Controls.Add(snakeOne);

            tailSnake2 = new List<PictureBox>();
            direction1 = 0;
            speed2 = -2.3;
            snakeTwo = new PictureBox();
            snakeTwo.Size = new Size(13, 13);
            snakeTwo.Location = new Point(ClientSize.Width - 60, 10);
            snakeTwo.BackColor = Color.Blue;
            Controls.Add(snakeTwo);
        }

    }
}
