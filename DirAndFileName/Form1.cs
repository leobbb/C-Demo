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

        private void btnOk_Click(object sender, EventArgs e)
        {
            Analyzer a = new Analyzer();
            string path = txtPath.Text.Trim();
            string dir, file;
            a.SplitPath(path, out dir, out file);
            txtDir.Text = dir;
            txtFN.Text = file;
        }
    }
}
