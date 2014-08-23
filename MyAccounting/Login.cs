using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            string userName = txtName.Text.Trim();
            string password = txtPwd.Text.Trim();

            string connString = "Data Source = (localdb)\\Projects; Initial Catalog = Financing; Integrated Security = True";
            
            SqlConnection conn = new SqlConnection(connString);

            string sql = String.Format("select count(*) from [User] where UserName = '{0}' and Password = '{1}'", userName, password);

            try
            {
                conn.Open();
                //lblShow.Text = "数据库连接已经建立  " + conn.State.ToString() + "\n" + conn.ConnectionString;
                SqlCommand command = new SqlCommand(sql, conn);
                //lblShow.Text += "创建命令对象" + "\n" + command.CommandText;
                
                int num = (int) command.ExecuteScalar();
                lblShow.Text += "  已经返回结果集";

                // int num = 0;
                if(num >0)
                {
                    MessageBox.Show("欢迎进入个人理财系统！", "登录成功", MessageBoxButtons.OK);
                    MainFrm mainForm = new MainFrm();
                    mainForm.Show();
                    this.Visible = false;
                }
                else 
                {
                    txtPwd.Text = "";
                    MessageBox.Show("您输入的用户名或密码错误！", "登录失败", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }

            }
            catch(Exception ex)
            {
                if (ex is ArgumentException)
                    MessageBox.Show(ex.Message,"连接字符串参数 无效",MessageBoxButtons.OK);
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
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
