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
    public partial class UserEdit : Form
    {
        public UserEdit()
        {
            InitializeComponent();
        }

        // 用于表示用户名是否可用
        bool tab2NameOk = false;

        private void UserEdit_Load(object sender, EventArgs e)
        {
            tsbInfo.Checked = true;
        }


        private void tsbInfo_Checked(object sender, EventArgs e)
        {
            if (tsbInfo.ForeColor != Color.Red)
                tsbInfo.ForeColor = Color.Red;
            else
                tsbInfo.ForeColor = Color.Black;
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Refresh_tabInfo();
                    break;
                case 1:
                    Refresh_tabAddUser();
                    break;
                case 2:
                    Refresh_tabAlter();
                    break;
            }
            tssDone.Text = tabControl1.SelectedTab.Text;

        }

        private void Refresh_tabAlter()
        {
            throw new NotImplementedException();
        }

        private void Refresh_tabAddUser()
        {
            // 无需要刷新的内容
        }

        private void Refresh_tabInfo()
        {
            int sum = 0;
            string sql = "SELECT [UserName] FROM [User] ";
            Login.command.CommandText = sql;

            try
            {
                // 防止在其他方法中调用是数据库连接已经出于打开状态
                Login.conn.Close();
                Login.conn.Open();
                Login.dataReader = Login.command.ExecuteReader();

                while (Login.dataReader.Read())
                {
                    tab1lsbShow.Items.Add(Login.dataReader["UserName"].ToString());
                    ++sum;
                }
                tab1lblShow.Text = string.Format("系统共有用户 {0} 个：", sum);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Login.dataReader.Close();
                Login.conn.Close();
            }
        }

        private void tab2btnAdd_Click(object sender, EventArgs e)
        {
            // 如果用户名或者密码为空，则返回重新输入。
            if (tab2Name.Text.Trim() == string.Empty || tab2Pwd.Text == string.Empty)
            {
                MessageBox.Show("用户名或者密码不能为空", "输入错误", MessageBoxButtons.OK);
                return;
            }
            // 如果用户名重复，则返回重新输入。
            if (!tab2NameOk)
            {
                MessageBox.Show("输入的用户名重复，请重新输入", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void tab2Name_Leave(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT COUNT(*) FROM [User] WHERE [UserName] = N'{0}'",
                tab2Name.Text.Trim());
            Login.command.CommandText = sql;
            try
            {
                Login.conn.Open();
                tssStatus.Text = "正在检索用户名是否可用...";
                int sum = (int)Login.command.ExecuteScalar();
                if (sum == 0)
                {
                    tssDone.Text = "用户名可用";
                    tab2NameOk = true;
                }
                else
                {
                    tab2NameOk = false;
                    tssDone.Text = "用户名不可用，请重新输入";
                    tab2Name.ForeColor = Color.Red;
                    tab2Name.Focus();
                }
                tssStatus.Text = "就绪";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Login.conn.Close();
            }
        }

        private void tab2Name_MouseClick(object sender, MouseEventArgs e)
        {
            tab2Name.ForeColor = Color.Black;
        }

        private void tab2Name_Enter(object sender, EventArgs e)
        {
            tssDone.Text = "输入用户名";
        }

        private void tab2Pwd_Enter(object sender, EventArgs e)
        {
            tssDone.Text = "输入密码";
        }




    }
}
