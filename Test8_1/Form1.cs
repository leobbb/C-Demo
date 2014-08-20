using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate int Caculate(int x, int y);

        public Caculate handler;

        public int Product(int x, int y)
        {
            return x * y;
        }

        public int Average(int x, int y)
        {
            return (x + y) / 2;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNuma.Text);
            int b = Convert.ToInt32(txtNumb.Text);

            handler = new Caculate(Product);
            lblShow.Text = "a 和 b 的乘积为：" + handler(a, b);

            handler = new Caculate(Average);
            lblShow.Text += "\na 和 b 的平均值为：" + handler(a, b);
        }



    }
}
