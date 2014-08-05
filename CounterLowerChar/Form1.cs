using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterLowerChar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSea_Click(object sender, EventArgs e)
        {
            //统计英文字母的个数
            int n = 0, i = 0;
            int m = txtContent.Text.Length;
            do
            {
                char c = txtContent.Text[i++];
                if (c > 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                    n++;
            } while (i != m);

            lblShow.Text = String.Format("共输入{1} 个字符，其中英文字母有： {0} 个。", n, m);
        }
    }
}
