using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test11_7
{
    public partial class SetDialog : Form
    {
        public SetDialog()
        {
            InitializeComponent();
        }

        // 公共属性，返回所设置的默认文档路径
        public string docPosition
        {
            get { return txtPosition.Text; }
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtPosition.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPosition.Text = "";
            this.Hide();
        }
    }
}
