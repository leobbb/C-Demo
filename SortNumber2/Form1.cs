using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortNumber2

{
    public partial class Form1 : Form
    {
        //输入一个数字序列，对其进行排序
        
        public Form1()
        {
            InitializeComponent();
        }

        //存储输入的可变字符串
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

            //Array.Sort(numArr);
            
            //使用冒泡排序实现
            BubblingSort(numArr);

            lblShow.Text += "\n排序后序列为：";
            for (int j = 0; j < numArr.Length; ++j)
            {
                lblShow.Text += numArr[j] + "   ";
            }
          
        }

        private void BubblingSort(float[] numArr)
        {
            float m = 0;
            bool change = false;
            for (int i = numArr.Length - 1; i >= 0; --i)
            {
                change = false;
                for (int j = 0; j < i; ++j)
                {
                    if (numArr[j] > numArr[j + 1])
                    {
                        m = numArr[j];
                        numArr[j] = numArr[j + 1];
                        numArr[j + 1] = m;
                        change = true;
                    }
                }
                if (!change)
                {
                    break;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Focus();
        }
    }
}
