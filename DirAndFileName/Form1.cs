using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirAndFileName
{
    public partial class Form1 : Form
    {
        // 用输出参数求文件路径中的目录和文件名。
        public Form1()
        {
            InitializeComponent();
        }

        // 声明委托类型
        delegate void Func(string s1 ,out string s2,out string s3);
        private void btnOk_Click(object sender, EventArgs e)
        {
            Analyzer a = new Analyzer();
            string path = txtPath.Text.Trim();
            string dir, file;
            // 实例化委托类型
            Func f = a.SplitPath;
            f(path, out dir, out file);
            txtDir.Text = dir;
            txtFN.Text = file;

            //String[] testStr = new String[10];
            //testStr[2] = "TestNoInitial";
            //txtDir.Text = testStr[2];

            //Analyzer[] testCla = new Analyzer[10];
            //testCla[2] = new Analyzer() { Num = 5 };
            //txtFN.Text = Convert.ToString(testCla[2].Num);

        }
    }
}
