using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Bomb
    {
        private Rectangle _rectangle;
        
        public delegate void Destroy(Bomb bomb);
        public event Destroy Destroyed;

        public Bomb(Rectangle rectangle) 
        {
            _rectangle = rectangle;
        }

        public void CheckCollision(Rectangle robotPosition)
        {
            if (_rectangle.IntersectsWith(robotPosition))
            {
                Destroyed.Invoke(this);
            }
        }
    }
}
