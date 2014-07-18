using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply result =  ping.Send(txtIP.Text);
            if (result.Status == IPStatus.Success)
            {
                MsgBox.Text = string.Format("测试成功。");
                MessageBox.Show("OK.");
                
            }
            else
                MsgBox.Text = string.Format("测试连接失败。");
        }
    }
}
