using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmartCar.Monitor
{
    class RealObject : PictureBox
    {
        public RealObject(SizeF realSize): base()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            RealSize = realSize;
            RealPosition = new PointF(0, 0);
        }

        public double RVscale = 10; //比例尺

        public SizeF RealSize { get; set; } //真实大小
        public Size VirtualSize //显示大小
        {
            get
            {
                return new Size((int)(RealSize.Width * RVscale), (int)(RealSize.Height * RVscale));
            }
        }

        public PointF RealPosition { get; set; } //真实坐标
        public Point VirtualPosition //显示坐标
        {
            get
            {
                return new Point((int)(RealPosition.X * RVscale), (int)(RealPosition.Y * RVscale));
            }
        }
        
        public int Direction { get; set; } //方向

        public PointF RealHead //物体头部的真实坐标
        {
            get
            {
                double rx = RealSize.Height / 2 * Math.Sin(Direction),
                       ry = RealSize.Height / 2 * Math.Cos(Direction);
                return new PointF((float)(RealPosition.X + rx), (float)(RealPosition.Y + ry));
            }
        }
        public PointF RealTail //物体尾部的真实坐标
        {
            get
            {
                double rx = RealSize.Height / 2 * Math.Sin(Direction),
                       ry = RealSize.Height / 2 * Math.Cos(Direction);
                return new PointF((float)(RealPosition.X - rx), (float)(RealPosition.Y - ry));
            }
        }
        public PointF RealLeft //物体左部的真实坐标
        {
            get
            {
                double rx = RealSize.Width / 2 * Math.Cos(Direction),
                       ry = RealSize.Width / 2 * Math.Sin(Direction);
                return new PointF((float)(RealPosition.X - rx), (float)(RealPosition.Y + ry));
            }
        }
        public PointF RealRight //物体右部的真实坐标
        {
            get
            {
                double rx = RealSize.Width / 2 * Math.Cos(Direction),
                       ry = RealSize.Width / 2 * Math.Sin(Direction);
                return new PointF((float)(RealPosition.X + rx), (float)(RealPosition.Y - ry));
            }
        }
        public Point VirtualHead { get { return new Point((int)(RealHead.X * RVscale), (int)(RealHead.Y * RVscale)); } }
        public Point VirtualTail { get { return new Point((int)(RealTail.X * RVscale), (int)(RealTail.Y * RVscale)); } }
        public Point VirtualLeft { get { return new Point((int)(RealLeft.X * RVscale), (int)(RealLeft.Y * RVscale)); } }
        public Point VirtualRight { get { return new Point((int)(RealRight.X * RVscale), (int)(RealRight.Y * RVscale)); } }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.Size = VirtualSize;
            base.OnPaint(pe);
        }
    }
}
