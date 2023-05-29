using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class Form1 : Form
    {
        private Robot _robot;
        private Dictionary<Keys, Point> _move = new Dictionary<Keys, Point>() 
        {
            { Keys.W, new Point(0,-1) },
            { Keys.S, new Point(0,1) },
            { Keys.A, new Point(-1,0) },
            { Keys.D, new Point(1,0) },
            { Keys.Up, new Point(0,-1) },
            { Keys.Down, new Point(0,1) },
            { Keys.Left, new Point(-1,0) },
            { Keys.Right, new Point(1,0) },
        };
        private Bomb _bomb = new Bomb(new Rectangle(350,350,100,100));
        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
            _robot = new Robot();
            _robot.Moved += OnMoved;
            _bomb.Destroyed += OnBombDestroy;
        }

        public bool OnMoved(Point pos)
        {
            if (pos.X < 0 || pos.Y < 0 || pos.X + RobotImage.Width > Size.Width || pos.Y + RobotImage.Height > Size.Height)
                return false;
            RobotImage.Left = pos.X;
            RobotImage.Top = pos.Y;
            _bomb.CheckCollision(new Rectangle(pos.X, pos.Y, 100,100));
            return true;
        }

        public void OnBombDestroy(Bomb bomb)
        {
            bomb.Destroyed -= OnBombDestroy;
            int x = _random.Next(0, Size.Width - 100);
            int y = _random.Next(0, Size.Height - 100);
            _bomb = new Bomb(new Rectangle(x, y, 100, 100));
            _bomb.Destroyed += OnBombDestroy;
            Bomb.Left = x;
            Bomb.Top = y;
            
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (_move.TryGetValue(e.KeyCode, out Point pos))
            {
                _robot.Move(pos);
            }
        }
    }
}
