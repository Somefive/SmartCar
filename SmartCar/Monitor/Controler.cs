using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCar.Monitor
{
    class Controller
    {
        //成员：car, building, panel;
        private View panel;
        private Car car;
        private Obstacle obstacle;
        Timer t = new Timer();
        void Draw()
        {
            Graphics g = panel.getGraphic();
            car.Draw(g);
            obstacle.Draw(g);
        }
        void Start()
        {
            t.Interval = 20;
            t.Tick += Calculate;
            t.Start();

        }
        private void Calculate(object sender, EventArgs e)
        {
            //运算 更新Car, building坐标状态等
            Draw();
        }
    }
}
