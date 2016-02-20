using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Monitor.Car car = new Monitor.Car();
            this.DisplayPanel.Controls.Add(car);
            car.RealPosition = new PointF(3, 3);
            car.Direction = Math.PI / 2;
            car.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
