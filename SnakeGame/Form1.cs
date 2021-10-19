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
        PictureBox snakeTwo;

        public Form1()
        {
            InitializeComponent();
            CreateSnakes();
        }
        private void CreateSnakes()
        {
            snakeOne = new PictureBox();
            snakeOne.Size = new Size(50,50);
            snakeOne.Location = new Point(10,10);
            snakeOne.BackColor = Color.Red;
            Controls.Add(snakeOne);

            snakeTwo = new PictureBox();
            snakeTwo.Size = new Size(50, 50);
            snakeTwo.Location = new Point(ClientSize.Width-60, 10);
            snakeTwo.BackColor = Color.Blue;
            Controls.Add(snakeTwo);
        }

    }
}
