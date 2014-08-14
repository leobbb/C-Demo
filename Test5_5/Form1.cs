using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display(Shape s)
        {
            lblShow.Text = "体积为： " + s.Cubage();
        }

        private void btnGlobe_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            Globe g = new Globe(r);
            Display(g);
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double h = Convert.ToDouble(txtHigh.Text);
            Cone co = new Cone(r, h);
            Display(co);
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRadius.Text);
            double h = Convert.ToDouble(txtHigh.Text);
            Cylinder cy = new Cylinder(r, h);
            Display(cy);
        }

    }
}
