using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Figure fi = new Circle(double.Parse(txt1.Text.Trim()));
            lblShow.Text = "圆形的面积为：" + Convert.ToString(fi.Area());
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Figure fi = new Rectangle(double.Parse(txt1.Text), double.Parse(txt2.Text));
            lblShow.Text = "矩形的面积为： " + Convert.ToString(fi.Area());
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Figure fi = new Triangle(double.Parse(txt1.Text), double.Parse(txt2.Text));
            lblShow.Text = "三角形的面积为： " + Convert.ToString(fi.Area());
        }
    }
}
