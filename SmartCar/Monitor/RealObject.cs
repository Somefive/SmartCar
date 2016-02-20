using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmartCar.Monitor
{
    class RealObject : Control
    {
        public delegate void PositionChangeHandler(PointF newPosition);
        public event PositionChangeHandler PositionChange;
        public delegate void DirectionChangeHandler(double newDirection);
        public event DirectionChangeHandler DirectionChange;

        public RealObject(SizeF realSize): base()
        {
            RealSize = realSize;
            RealPosition = new PointF(0, 0);
            Direction = 0;
            Size = new Size(10, 10);
        }
        public Image Image; //图像
        public double RVscale = 10; //比例尺

        public SizeF RealSize { get; set; } //真实大小
        public Size VirtualSize //显示大小
        {
            get
            {
                return new Size((int)(RealSize.Width * RVscale), (int)(RealSize.Height * RVscale));
            }
        }

        private PointF realPosition;
        public PointF RealPosition //真实坐标
        {
            get { return realPosition; }
            set
            {
                realPosition = value;
                if (PositionChange != null)
                    PositionChange(value);
                this.Refresh();
            }
        }
        public Point VirtualPosition //显示坐标
        {
            get
            {
                return new Point((int)(RealPosition.X * RVscale), (int)(RealPosition.Y * RVscale));
            }
        }

        private double direction = 0;
        public double Direction //方向（弧度值）
        {
            get { return direction; }
            set
            {
                direction = value;
                if (DirectionChange != null)
                    DirectionChange(value);
                this.Refresh();
            }
        }
        public int DirectionDegree //方向（角度制）
        {
            get
            {
                return (int)(Direction * 180 / Math.PI) % 360;
            }
        }
        public PointF RealHead //物体头部的真实坐标
        {
            get
            {
                double rx = RealSize.Height / 2 * Math.Sin(Direction),
                       ry = RealSize.Height / 2 * Math.Cos(Direction);
                return new PointF((float)(RealPosition.X + rx), (float)(RealPosition.Y - ry));
            }
        }
        public PointF RealTail //物体尾部的真实坐标
        {
            get
            {
                double rx = RealSize.Height / 2 * Math.Sin(Direction),
                       ry = RealSize.Height / 2 * Math.Cos(Direction);
                return new PointF((float)(RealPosition.X - rx), (float)(RealPosition.Y + ry));
            }
        }
        public PointF RealLeft //物体左部的真实坐标
        {
            get
            {
                double rx = RealSize.Width / 2 * Math.Cos(Direction),
                       ry = RealSize.Width / 2 * Math.Sin(Direction);
                return new PointF((float)(RealPosition.X - rx), (float)(RealPosition.Y - ry));
            }
        }
        public PointF RealRight //物体右部的真实坐标
        {
            get
            {
                double rx = RealSize.Width / 2 * Math.Cos(Direction),
                       ry = RealSize.Width / 2 * Math.Sin(Direction);
                return new PointF((float)(RealPosition.X + rx), (float)(RealPosition.Y + ry));
            }
        }
        public Point VirtualHead { get { return new Point((int)(RealHead.X * RVscale), (int)(RealHead.Y * RVscale)); } }
        public Point VirtualTail { get { return new Point((int)(RealTail.X * RVscale), (int)(RealTail.Y * RVscale)); } }
        public Point VirtualLeft { get { return new Point((int)(RealLeft.X * RVscale), (int)(RealLeft.Y * RVscale)); } }
        public Point VirtualRight { get { return new Point((int)(RealRight.X * RVscale), (int)(RealRight.Y * RVscale)); } }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.Height = (int)(Math.Abs(VirtualSize.Height * Math.Cos(Direction)) + Math.Abs(VirtualSize.Width * Math.Sin(Direction)));
            this.Width = (int)(Math.Abs(VirtualSize.Height * Math.Sin(Direction)) + Math.Abs(VirtualSize.Width * Math.Cos(Direction)));
            this.Location = new Point(VirtualPosition.X - Width / 2, VirtualPosition.Y - Height / 2);
            Graphics g = this.CreateGraphics();
            Point head = VirtualHead, position = VirtualPosition, tail = VirtualTail, left = VirtualLeft, right = VirtualRight;
            Point leftup = new Point(left.X+head.X-position.X-Location.X,left.Y+head.Y-position.Y-Location.Y),
                  rightup = new Point(right.X + head.X - position.X - Location.X, right.Y + head.Y - position.Y - Location.Y),
                  leftdown = new Point(left.X + tail.X - position.X - Location.X, left.Y + tail.Y - position.Y - Location.Y);
            Point[] imagearea = { leftup, rightup, leftdown };
            g.DrawImage(this.Image, imagearea);
            base.OnPaint(pe);
        }
    }
}
