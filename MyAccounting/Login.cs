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
        public static readonly SqlConnection conn;
        public static SqlCommand command;
        public static SqlDataReader dataReader;

        public Login()
        {
            InitializeComponent();
        }

        static Login()
        {           
            string connString = "Data Source = (localdb)\\Projects; Initial Catalog = Financing; Integrated Security = True";
            Login.conn = new SqlConnection(connString);
            Login.command = new SqlCommand();
            Login.command.Connection = Login.conn;
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text.Trim();
            string password = txtPwd.Text;
            
            string sql = String.Format("select count(*) from [User] where [UserName] = N'{0}' and [Password] = N'{1}'", userName, password);

            try
            {
                Login.conn.Open();
                Login.command.CommandText = sql;
                
                int num = (int) Login.command.ExecuteScalar();
                lblShow.Text += "  已经返回结果集";

                if(num >0)
                {
                    MessageBox.Show("欢迎进入个人理财系统！", "登录成功", MessageBoxButtons.OK);
                    MainFrm mainForm = new MainFrm();

                    // 类Login预定类MainFrm 的关闭窗口事件，当MainFrm关闭，Login窗口也关闭。
                    mainForm.FormClosed += new FormClosedEventHandler(CloseMe);
                    mainForm.Show();
                    this.Hide();
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
                Login.conn.Close();
            }
        }

        private void CloseMe(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }

        // 程序关闭是弹出一个窗口
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Good bye.", "", MessageBoxButtons.OK);
        }
    }
}
