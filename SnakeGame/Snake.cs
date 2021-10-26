using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Snake
    {
        public List<PointF> Tail { get; set; }
        public PointF Head { get; set; }
        public double Speed { get; set; }
        public double Direction { get; set; }

        public Snake()
        {
            Tail = new List<PointF>();
            Head = new Point();
        }
        public void Forward()
        {
            Tail.Add(Head);
            var changeX = Speed * Math.Cos(Direction);
            var changeY = Speed * -Math.Sin(Direction);
            Head = new PointF(Convert.ToSingle(Tail[Tail.Count - 1].X + changeX), Convert.ToSingle(Tail[Tail.Count - 1].Y + changeY));
        }
        public void TurnLeft()
        {
            Direction += 0.3;

        }
        public void TurnRight()
        {
            Direction -= 0.3;
        }
        public List<PictureBox> GetPictureBoxes(Color color, int size)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            var halfSize = size / 2f;
            foreach (var point in Tail)
            {
                pictureBoxes.Add(new PictureBox() { Location = new Point(), BackColor = color });
            }
            return pictureBoxes;
        }
    }
}
