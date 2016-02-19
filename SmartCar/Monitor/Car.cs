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
        
    }
}
