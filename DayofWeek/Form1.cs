using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayofWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum WeekDay { 星期天, 星期一, 星期二, 星期三, 星期四, 星期五, 星期六 };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(txtDate.Text);
            WeekDay wd = (WeekDay)dt.DayOfWeek;
            lblShow.Text = "这一天是" + wd + ".";
            lblShow.Text += "\nThis is " + dt.DayOfWeek + ".";

        }
    }
}
