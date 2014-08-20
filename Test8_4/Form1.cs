using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSource_Enter(object sender, EventArgs e)
        {
            txtSource.Text = "";
        }

        // 实现输入和显示 同步
        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            lblShow.Text = "正在输入：\n" + txtSource.Text;
        }

        private void txtSource_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("字符串复制成功", "恭喜", MessageBoxButtons.OK);
        }
    }
}
