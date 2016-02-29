using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SmartCar.Monitor
{
    class Car: RealObject
    {
        private Timer timer = new Timer();
        private bool move = false;
        private bool reotate = false;//决定是否旋转
        private PointF realRotateC;//引入旋转中心
        private double radius = 500;//默认曲率半径
        private double velocity = 10;//默认车速

        public Car() : base(new SizeF(1.7f, 3.6f))
        {
            this.Image = Properties.Resources.Car_00;
            realRotateC = RealPosition;
        }

        public double RealSpeed; //真实车速
        
        public double RealAccelerate; //真实加速度

        /*
         * 认为转弯是先确定转弯半径，然后进行转弯
         */
        public double R //车的中心点到旋转中心的距离
        {
            get
            {
                return Math.Sqrt(Math.Pow(realRotateC.X - RealPosition.X, 2) + Math.Pow(realRotateC.Y - RealPosition.Y, 2));
            }
        }
        public void TurnRight() //右转
        {
            double arc = velocity / radius;
            Direction += arc;
        }

        public void TurnLeft() //左转
        {
            double arc = velocity/radius;
            Direction -= arc;
        }

        public void SuperBrake() //急刹
        {
            RealSpeed = 0;
            RealAccelerate = 0;
        }

        public void Forward(double distance)
        {
            RealPosition = new PointF((float)(RealPosition.X+distance*Math.Sin(Direction)),(float)(RealPosition.Y-distance*Math.Cos(Direction)));
        }


        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                Forward(1);
            else if (e.KeyCode == Keys.Left)
                TurnLeft();
            else if (e.KeyCode == Keys.Right)
                TurnRight();
            else if (e.KeyCode == Keys.Down)
                Forward(-1);
            base.OnKeyUp(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                Forward(1);
            else if (e.KeyCode == Keys.A)
                radius--;
            else if (e.KeyCode == Keys.S)
                realRotateC.Y--;
            else if (e.KeyCode == Keys.D)
               radius++;
            else if (e.Control && e.KeyCode == Keys.Up)
            {
                Forward(1);
                TurnRight();
            }
            else if (e.Control && e.KeyCode == Keys.Down)
            {
                Forward(-1);
                TurnRight();
            }
            base.OnKeyDown(e);
        }

        protected override void OnClick(EventArgs e)
        {
            if(!move)
            {
                move = true;
                timer.Interval = 50;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            else
            {
                move = false;
                timer.Stop();
            }
            base.OnClick(e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Forward(0.05);
            if (Direction <= Math.PI / 2)
                TurnRight();
            else
                TurnLeft();
            radius -= 1;
        }
    }
    
}
