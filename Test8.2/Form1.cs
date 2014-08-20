using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8._2
{
    public partial class Form1 : Form
    {
        private Boiler boiler;

        public Form1()
        {
            InitializeComponent();
            boiler = new Boiler();
            if (boiler.AlarmIsNull)
                boiler.onAlarm += new EventHandler<BoilerArgs>(boiler_Alarm);
        }

        private void boiler_Alarm(object sender, BoilerArgs e)
        {
            if (e.Press > 50 && e.Press < 80)
                lblShow.Text = "黄色警报";
            else if (e.Press >= 80 && e.Press < 90)
                lblShow.Text = "橙色警报";
            else if (e.Press >= 90 && e.Press < 100)
                lblShow.Text = "红色警报";
            else if (e.Press == 100)
            {
                lblShow.Text = "已经降压！";
                txtpressure.Text = 30 + "MPa";
                boiler.k = 30;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            autoTimer.Start();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            lblShow.Text = "手动降压成功";
            txtpressure.Text = 30 + "MPa";
            boiler.k = 30;
        }

        int i = 0;
        private void autoTimer_Tick(object sender, EventArgs e)
        {
            ++i;
            if (i / 10 == 1)
            {
                i = 1;
                boiler.k++;
                txtpressure.Text = boiler.k + "MPa";
                boiler.ProcessAlarm();
            }
        }


    }
}
