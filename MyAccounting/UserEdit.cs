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
        // 信息是否需要更新（标记数据库信息已经修改，需要更新）
        bool infoUpdate = false;
        // 第一次加载时进行刷新
        bool firstLoad = true;

        private void UserEdit_Load(object sender, EventArgs e)
        {
            tsbInfo.Checked = true;
            Refresh_tabInfo();
        }

        private void tsbInfo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tsbAddUser.Checked = false;
            tsbAlter.Checked = false;
        }

        private void tsbAddUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tsbInfo.Checked = false;
            tsbAlter.Checked = false;
        }

        private void tsbAlter_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            tsbInfo.Checked = false;
            tsbAddUser.Checked = false;
        }

        private void tsbAddUser_CheckedChanged(object sender, EventArgs e)
        {
            tsbChangeColor(tsbAddUser);
        }

        private void tsbAlter_CheckedChanged(object sender, EventArgs e)
        {
            tsbChangeColor(tsbAlter);
        }


        private void tsbInfo_Checked(object sender, EventArgs e)
        {
            tsbChangeColor(tsbInfo);            
        }

        private void tsbChangeColor(ToolStripButton tsbBtn)
        {
            if (tsbBtn.Checked)
                tsbBtn.ForeColor = Color.Blue;
            else
                tsbBtn.ForeColor = Color.Black;

        }

        // 控制每页的显示
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 在状态栏显示当前选项卡的内容
            tssDone.Text = tabControl1.SelectedTab.Text;
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
        }



        #region tab1 相关代码区域
        private void Refresh_tabInfo()
        {
            // 设置按下Enter键时的操作
            this.AcceptButton = null;
            this.CancelButton = null;

            if (!(firstLoad || infoUpdate))
                return;
            int sum = 0;
            string sql = "SELECT [UserName] FROM [User] ";
            Login.command.CommandText = sql;
            tab1lsbShow.Items.Clear();
            try
            {
                // 防止在其他方法中调用是数据库连接已经出于打开状态
                Login.conn.Close();
                Login.conn.Open();
                tssStatus.Text = "正在查询数据库";
                Login.dataReader = Login.command.ExecuteReader();

                while (Login.dataReader.Read())
                {
                    tab1lsbShow.Items.Add(Login.dataReader["UserName"].ToString());
                    ++sum;
                }
                tab1txtShow.Text = string.Format("系统共有用户 {0} 个：", sum);
                tssDone.Text = "数据库查询成功";
                tssStatus.Text = "就绪";
                tab1lsbShow.SelectedIndex = 0;
                firstLoad = false;
                infoUpdate = false;
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

        private void tab1tsmEdit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            tab3OldName.Text = tab1lsbShow.SelectedItem.ToString();
            tab3OldName.ReadOnly = true;
            tab3lblShow.Text = "请输入新的用户名或者密码";
            tab3btnSearch.Enabled = false;
            panel1Show();
        }

        private void tab1tsmDel_Click(object sender, EventArgs e)
        {
            string oldName = tab1lsbShow.SelectedItem.ToString();
            if (oldName == "admin")
            {
                MessageBox.Show("管理员账户不能删除", "操作出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql = string.Format("DELETE FROM [User] WHERE [Username] = N'{0}'", oldName);
            Login.command.CommandText = sql;
            try
            {
                Login.conn.Open();
                tssStatus.Text = "正在连接数据库... ";
                int sum = Login.command.ExecuteNonQuery();
                // 标记数据库信息已经修改
                infoUpdate = true;
                if (sum == 1)
                {
                    MessageBox.Show("恭喜！\n用户信息已经删除。", "操作成功", MessageBoxButtons.OK);
                    Login.conn.Close();
                    Refresh_tabInfo();

                    tssDone.Text = "用户信息删除成功";
                }
                else
                {
                    MessageBox.Show("操作出现错误", "操作失败", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Login.conn.Close();
                    Refresh_tabInfo();
                    tssDone.Text = "操作失败";
                }
                tssStatus.Text = "就绪";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Login.conn.Close();
            }
        }
        private void tab1lsbShow_DoubleClick(object sender, EventArgs e)
        {
            tab1tsmEdit_Click(sender, e);
        }

        #endregion 

        #region tab2 相关代码

        private void Refresh_tabAddUser()
        {
            // 设置按下Enter键时的操作
            this.AcceptButton = tab2btnAdd;
            this.CancelButton = tab2btnClear;
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

            string name = tab2Name.Text.Trim();
            string pwd = tab2Pwd.Text;

            string sql = string.Format("INSERT INTO [User]([UserName], [Password]) VALUES(N'{0}', N'{1}')", name, pwd);
            Login.command.CommandText = sql;
            try
            {
                Login.conn.Open();
                tssStatus.Text = "正在添加用户信息... ";
                // 执行输入插入操作，返回受影响的行数。
                int sum = Login.command.ExecuteNonQuery();
                if (sum == 1)
                {
                    MessageBox.Show("用户信息添加成功", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tssDone.Text = "用户信息添加成功";
                    // 标记数据库信息已经修改，需要更新
                    infoUpdate = true;
                    tab2btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("用户信息添加失败", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tssDone.Text = "用户信息添加失败";
                    tab2NameOk = false;
                }
                tssStatus.Text = "就绪";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Login.conn.Close();
            }

        }

        private void tab2Name_Leave(object sender, EventArgs e)
        {
            if (tab2Name.Text.Trim() == string.Empty)
                return;
            CheckName(tab2Name,ref tab2NameOk);

        }

        private void CheckName(TextBox tab2Name, ref bool nameOk)
        {

            string sql = string.Format("SELECT COUNT(*) FROM [User] WHERE [UserName] = N'{0}'",
                tab2Name.Text.Trim());
            Login.command.CommandText = sql;
            try
            {
                Login.conn.Close();
                Login.conn.Open();
                tssStatus.Text = "正在检索用户名是否可用...";
                int sum = (int)Login.command.ExecuteScalar();
                tssStatus.Text = "就绪";
                if (sum == 0)
                {
                    tssDone.Text = "用户名可用";
                    nameOk = true;
                }
                else
                {
                    
                    tssDone.Text = "用户名不可用，请重新输入";
                    tab2Name.ForeColor = Color.Red;
                    tab2Name.Focus();
                    nameOk = false;
                }
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

        //private void tab2Name_Enter(object sender, EventArgs e)
        //{
        //    tssDone.Text = "输入用户名";
        //}

        //private void tab2Pwd_Enter(object sender, EventArgs e)
        //{
        //    tssDone.Text = "输入密码";
        //}

        private void tab2btnClear_Click(object sender, EventArgs e)
        {
            tab2Name.Text = "";
            tab2Name.Focus();
            tab2NameOk = false;
            tab2Pwd.Text = "";
        }

        private void tab2Name_TextChanged(object sender, EventArgs e)
        {
            tab2Name.ForeColor = Color.Black;
        }
        private void tabAddUser_Click(object sender, EventArgs e)
        {
            tab2btnAdd.Focus();
        }

        // 非必需代码
        private void tabAddUser_MouseDown(object sender, MouseEventArgs e)
        {
            this.tabAddUser.Cursor = System.Windows.Forms.Cursors.IBeam;
        }
        // 非必需代码
        private void tabAddUser_MouseUp(object sender, MouseEventArgs e)
        {
            this.tabAddUser.Cursor = System.Windows.Forms.Cursors.Default;
        }

        #endregion

        #region tab3 相关代码

        private void Refresh_tabAlter()
        {
            if(tab3btnSearch.Enabled)
                panel1.Visible = false;
            // 如果数据库信息已经修改，则使文本框可编辑。
            if (infoUpdate)
            {
                tab3OldName.ReadOnly = false;
                tab3btnSearch.Enabled = true;
            }

        }

        private void tab3OldName_TextChanged(object sender, EventArgs e)
        {
            tab3OldName.ForeColor = Color.Black;
        }

        private void tab3btnSearch_Click(object sender, EventArgs e)
        {
            if (tab3OldName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户名不能为空！", "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tab3OldName.Focus();
                return;
            }

            tab3OldName.ReadOnly = true;
            string oldName = tab3OldName.Text.Trim();
            string sql = string.Format("SELECT COUNT(*) FROM [User] WHERE [UserName] = N'{0}' ", oldName);
            Login.command.CommandText = sql;

            try
            {
                Login.conn.Open();
                tssStatus.Text = "正在查询数据库...";
                int sum = (int)Login.command.ExecuteScalar();
                if (sum == 1)
                {
                    tab3lblShow.Text = "请输入新的用户名或者密码";
                    tab3btnSearch.Enabled = false;
                    tssDone.Text = "已查询到用户信息";
                    panel1Show();
                }
                else
                {
                    DialogResult diaRes = MessageBox.Show("无用户信息，无法修改。\n是否继续编辑输入？", "查询出错", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (diaRes == DialogResult.OK)
                        tab3OldName.ForeColor = Color.Red;
                    else
                        tab3OldName.Text = string.Empty;
                    
                    tab3OldName.ReadOnly = false;
                    tab3OldName.Focus();
                    tssDone.Text = "无用户信息";
                }
                tssStatus.Text = "就绪";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Login.conn.Close();
            }
        }
        private void tab3btnBack_Click(object sender, EventArgs e)
        {
            tssDone.Text = tabAlter.Text;
            tssStatus.Text = "就绪";
            tab3lblShow.Text = "";
            panel1.Visible = false;
            tab3OldName.Focus();
            tab3OldName.ReadOnly = false;
            tab3btnSearch.Enabled = true;
        }
        bool tab3NameOk = false;

        //private void panel1_VisibleChanged(object sender, EventArgs e)
        //{
        //    tab3NameOk = false;
        //    tab3NewName.Text = "";
        //    tab3NewPwd.Text = "";
        //}

        private void panel1Show()
        {
            panel1.Visible = true;
            tab3NameOk = false;
            tab3NewName.Enabled = true;
            tab3NewName.Focus();
            tab3NewName.Text = "";
            tab3NewPwd.Text = "";
            if (tab3OldName.Text.Trim() == "admin")
                tab3NewName.Enabled = false;
        }
      

        private void tab3NewName_TextChanged(object sender, EventArgs e)
        {
            tab3NewName.ForeColor = Color.Black;
            tab3NameOk = false;
        }
        
        private void panel1_Click(object sender, EventArgs e)
        {
            tab3btnAlter.Focus();
            tssStatus.Text = "就绪";
        }

        private void tab3NewName_Leave(object sender, EventArgs e)
        {
            if (tab3NewName.Text.Trim() == string.Empty)
                return;
            CheckName(tab3NewName, ref tab3NameOk);
        }

        private void tab3btnAlter_Click(object sender, EventArgs e)
        {
            if (tab3NewName.Text.Trim() == string.Empty && tab3NewPwd.Text == string.Empty)
            {
                MessageBox.Show("不能全为空\n请输入用户名或者密码", "输入出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tab3NewName.Focus();
                return;
            }
            
            string oldName = tab3OldName.Text.Trim();
            string newName = tab3NewName.Text.Trim();
            string pwd = tab3NewPwd.Text;

            string sql = string.Empty;
            if (newName == string.Empty)
            {
                // 用户名为空，则只修改密码。
                sql = string.Format("UPDATE [User] SET [Password] = N'{0}' WHERE [Username] = N'{1}' ", pwd, oldName);
            }
            else if (tab3NameOk == false)
            {
                MessageBox.Show("用户名不可用", "输入出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (pwd == string.Empty)
            {
                // 如果密码为空，则只修改用户名。
                sql = string.Format("UPDATE [User] SET [Username] = N'{0}' WHERE [Username] = N'{1}' ", newName, oldName);
            }
            else
            {
                // 如果都不为空，则同时修改用户名和密码。
                sql = string.Format("UPDATE [User] SET [Username] = N'{0}',[Password] = N'{1}' WHERE [Username] = N'{2}'",
                    newName, pwd, oldName);
            }

            Login.command.CommandText = sql;
            try
            {
                Login.conn.Open();
                tssStatus.Text = "正在处理请求... ";
                int sum = Login.command.ExecuteNonQuery();

                if (sum == 1)
                {
                    MessageBox.Show("恭喜，信息修改成功。", "操作成功", MessageBoxButtons.OK);
                    //tab3NewName.Text = "";
                    //tab3NewPwd.Text = "";
                    panel1.Visible = false;
                    // 标记数据库信息已经修改
                    infoUpdate = true;

                    tssDone.Text = "信息修改成功";
                    tab3lblShow.Text = "";
                    tab3OldName.ReadOnly = false;
                    tab3OldName.Text = string.Empty;
                    tab3OldName.Focus();
                    tab3btnSearch.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("信息修改失败", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tab3NewName.Focus();
                    tssDone.Text = "信息修改失败";
                }
                tssStatus.Text = "就绪";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作错误", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            finally
            {
                Login.conn.Close();
            }
        }


        #endregion

    }
}
