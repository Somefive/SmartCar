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
        public Car() : base(new SizeF(1.7f, 3.6f))
        {
            this.Image = Properties.Resources.Car_00;
            this.RVscale = 20;
        }

        public double RealSpeed; //真实车速
        
        public double RealAccelerate; //真实加速度

        public void TurnRight(int degree) //右转
        {
            double arc = degree * Math.PI / 180;
            Direction += arc;
        }

        public void TurnLeft(int degree) //左转
        {
            double arc = degree * Math.PI / 180;
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
                TurnLeft(15);
            else if (e.KeyCode == Keys.Right)
                TurnRight(15);
            else if (e.KeyCode == Keys.Down)
                Forward(-1);
            base.OnKeyUp(e);
        }
        
    }
}
