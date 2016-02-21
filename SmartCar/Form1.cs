using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCar.Monitor;

namespace SmartCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RealObject.RVscale = 20;
            Car car1 = new Monitor.Car();
            Car car2 = new Monitor.Car();
            this.DisplayPanel.Controls.Add(car1);
            this.DisplayPanel.Controls.Add(car2);
            car1.RealPosition = new PointF(3, 3);
            car2.RealPosition = new PointF(6, 6);
            car1.Direction = Math.PI / 2;
            
            car1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
