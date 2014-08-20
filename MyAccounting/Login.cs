using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string password = txtPwd.Text;

            if (userName == "admin" && password == "123")
            {
                MessageBox.Show("欢迎进入个人理财系统！", "登录成功", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("您输入的用户名或密码错误！", "登录失败", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }
    }
}
