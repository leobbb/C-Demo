using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortNumber
{
    public partial class Form1 : Form
    {
        //输入一个数字序列，对其进行排序
        
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder str = new StringBuilder();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            str.Append(txtNum.Text + ",");
            lblShow.Text = "输入的序列为： " + str.ToString();
            txtNum.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // 把字符串以“，”分隔为字符串数组，并且去掉空字符串           
            string[] numStr = str.ToString().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); 

            lblShow.Text += "\n共输入 " + numStr.Length + " 个数";

            float[] numArr = new float[numStr.Length];

            //把字符串数组转化为浮点数数组
            for (int i = 0; i < numStr.Length; i++)
            {
                numArr[i] = float.Parse(numStr[i]);
            }

            Array.Sort(numArr);
            lblShow.Text += "\n排序后序列为：";
            for (int j = 0; j < numArr.Length; ++j)
            {
                lblShow.Text += numArr[j] + "   ";
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Focus();
        }
    }
}
