using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCar.Monitor
{
    class View:Control
    {
        public View() : base(){}
        public Graphics getGraphic()
        {
            Graphics g = base.CreateGraphics();
            return g;
        }
    }
    
}
