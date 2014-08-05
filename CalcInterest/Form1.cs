using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcInterest
{
    public partial class Form1 : Form
    {
        private double _money;

        public double Money
        {
            get { return _money; }
            set { _money = value; }
        }
        private double _rate;

        public double Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        private int _time;

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMoney.Text = "10000";
            txtRate.Text = "2.25";
            lstYear.SelectedItem = "2年";
            btnCalc.Focus();
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sum = CalcInt();
            sumShow(sum);
        }

        private void sumShow(double sum)
        {
            lblShow.Text = "本金为 " + txtMoney.Text + " 元\n" + "存期为 " + lstYear.SelectedItem + " \n";
            lblShow.Text += "本息和为 " + sum + " 元";

        }

        private double CalcInt()
        {
            double sum = 0;
            int time = 0;
            string str = (string)lstYear.SelectedItem;
            switch (str)
            {
                case "1年" :
                    time = 1;
                    break;
                case "2年" :
                    time = 2;
                    break;
                case "3年":
                    time = 3;
                    break;
                case "4年" :
                    time = 4;
                    break;

            }
            sum = double.Parse(txtMoney.Text) * double.Parse(txtRate.Text) / 100 * time;
            sum += double.Parse(txtMoney.Text);
            return sum;
        }
    }
}
