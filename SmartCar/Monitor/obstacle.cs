﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCar.Monitor
{
    class Obstacle:RealObject
    {
        public Obstacle():base(new SizeF(1,1))
        {
        }
        public void Draw(Graphics g)
        {
        }
    }
}
