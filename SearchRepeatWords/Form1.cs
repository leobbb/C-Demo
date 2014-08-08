using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchRepeatWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct RepeatWords
        {
            public string words;
            public int num;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtContent.Text.Trim();
            RepeatWords[] rst = new RepeatWords[10];
            int sum = 0;
            SearchRW(ref rst, out sum, str);

            if (rst[0].words == null)
            {
                lblShow.Text = "输入的文字中没有重复的双字词汇。";
            }
            else
            {
                ShowRst(rst,sum);
            }
            
        }

        private void ShowRst(RepeatWords[] rst, int sum)
        {
            lblShow.Text = String.Format("一共有 {0} 个重复词汇。\n其中：", sum);
            for (int i = 0; i < sum; ++i)
            {
                lblShow.Text += String.Format("\"{0}\"重复了 {1} 次，", rst[i].words, rst[i].num);
            }
            lblShow.Text += "。";
        }
        private void SearchRW(ref RepeatWords[] rst,out int sum, string str)
        {
            sum = 0;
            for (int j = 0, i = 0; i < str.Length - 3; ++i)
            {
                if (ExistInResult(ref rst, str[i].ToString() + str[i + 1].ToString()))
                {
                    continue;
                }

                for (j = i + 2; j < str.Length -1; ++j)
                {
                    if (str[i] == str[j] && str[i+1] == str[j+1] )
                    {
                        rst[sum].num += 1;
                        rst[sum].words = str[i].ToString() + str[i + 1].ToString();
                    }
                }
                if (rst[sum].num != 0)
                {
                    ++sum;
                }

            }
        }

        private bool ExistInResult(ref RepeatWords[] rst, string p)
        {
            for (int i = 0; i < rst.Length; ++i)
            {
                if (rst[i].num == 0)
                {
                    break;
                }
                if (rst[i].words == p)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
