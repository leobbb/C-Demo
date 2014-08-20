using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[10];
        delegate bool Compare(int x, int y);

        bool Ascending(int x, int y)
        {
            return x < y;
        }

        bool Descding(int x, int y)
        {
            return x > y;
        }

        void SortArray(Compare comp)
        {
            for (int i = 0; i < a.Length; ++i) 
                for(int j =0; j < a.Length -i; ++ j)
                    if (comp(a[j+1], a[j]))
                    {
                        int t = a[j];
                        a[j] = a[j+1];
                        a[j+1] = t;
                    }
        }

        void Display()
        {
            txtTarget.Text = "";
            foreach (int i in a)
                txtTarget.Text += i + "\r\n";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
            txtTarget.Text = "";
            Random r = new Random();
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = r.Next(100);
                txtSource.Text += a[i] + "\r\n";
            }
        }

        private void btnDescSort_Click(object sender, EventArgs e)
        {
            SortArray(new Compare(Descding));
            Display();
        }

        private void btnAscSort_Click(object sender, EventArgs e)
        {
            SortArray(new Compare(Ascending));
            Display();
        }
    }
}
