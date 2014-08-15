using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMp3_Click(object sender, EventArgs e)
        {
            Mp3 m = new Mp3();
            if (m is IUsb)
            {
                IUsb iu = (IUsb)m;
                lblShow.Text = iu.TransData("计算机", "MP3设备");
            }
           
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            Mobile mob = new Mobile();
            IUsb iu = mob as IUsb;
            if (iu != null) lblShow.Text = iu.TransData("计算机", "手机");

            IBluetooth ib = mob as IBluetooth;
            if (ib != null) lblShow.Text += "\n" + ib.TransData("手机", "计算机");
            lblShow.Text += "\n" + mob.Call("父亲");
        }
    }
}
