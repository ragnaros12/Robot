using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    {
        public delegate bool RobotMoved(Point point);
        public event RobotMoved Moved;


        private readonly Point MoveSpeed = new Point(10,10);
        private Rectangle _rectangle;

        public Robot()
        {
            _rectangle = new Rectangle(0, 0, 100, 100);
        }
        public void Move(Point by)
        {
            Point pos = new Point(_rectangle.X + by.X * MoveSpeed.X, _rectangle.Y + by.Y * MoveSpeed.Y);
            if (Moved.Invoke(pos))
            {
                _rectangle.X = pos.X;
                _rectangle.Y = pos.Y;
            }
        }
    }
}
