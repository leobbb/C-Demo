using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test9_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mfrm = new ModelForm("这是一个模态对话框");
            mfrm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form ufrm = new ModelForm("这是一个普通的对话框");
            ufrm.Show();
        }
    }
}
