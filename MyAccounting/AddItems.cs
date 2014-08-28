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
    public partial class AddItems : Form
    {

        public AddItems()
        {
            InitializeComponent();
        }

        private void rdoExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            // 调用更新下拉列表的方法
            AddItems.UpdateCategory(cboCategory,rdoExpenditure.Checked);
        }

        // 更新下拉列表的方法，第一个参数是需要更新的对象，第二个参数是显示的类别（收入或者支出）
        public static void UpdateCategory(ComboBox cboCategory, bool isPayout)
        { 
               
            // 添加类别信息
            cboCategory.Items.Clear();
            cboCategory.Items.Add(new Category(0, "一级大类"));
            string sql = string.Empty;

            // 判断需要更新的类别（支出为1，收入为0）
            if(isPayout)    
                sql = "SELECT * FROM [Category] WHERE [IsPayout] = 1";
            else
                sql = "SELECT * FROM [Category] WHERE [IsPayout] = 0";

            Login.command.CommandText = sql;
           
            try
            {
                // 使用类 Login 里的静态成员 conn, command dataReader 
                Login.conn.Close();
                Login.conn.Open();
                Login.dataReader = Login.command.ExecuteReader();

                while (Login.dataReader.Read())
                {
                    // 通过索引号读取dataReader 对象中的第1列数据
                    int cId = (int)Login.dataReader[0];
                    // 通过列的名称读取dataReader 对象中的数据
                    string name = Login.dataReader["CategoryName"].ToString().Trim();
                    // 像cboCategory 中添加对象
                    cboCategory.Items.Add(new Category(cId, name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Login.dataReader.Close();
                Login.conn.Close();
            }
            cboCategory.SelectedIndex = 0;
        }

        
        private void AddItems_Load(object sender, EventArgs e)
        {
            // 窗体加载后，单选按钮选择支出
            this.rdoExpenditure.Checked = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请填写收支项目名称！","信息不完整",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
                tabControl1.SelectedTab = tabPage2;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请填写收支项目名称！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedTab = tabPage1;
                    txtName.Focus();
                }
                else
                {
                    rtxtMsg.Clear();
                    rtxtMsg.AppendText("要添加的收支项目为：");
                    rtxtMsg.AppendText(txtName.Text);
                    rtxtMsg.AppendText("\n所属类别：" + cboCategory.SelectedItem.ToString());
                    if (rdoExpenditure.Checked == true)
                        rtxtMsg.AppendText("\n是支出类型的项目");
                    else
                        rtxtMsg.AppendText("\n是收入类型的项目");
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // 项目的名称
            string name = txtName.Text.Trim();
            if (name == string.Empty)
            {
                MessageBox.Show("请填写收支项目名称！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabControl1.SelectedTab = tabPage1;
                txtName.Focus();
                return;
            }

            // 类别的分类（收入或者支出，1 为支出）
            int isPayout = rdoExpenditure.Checked?1:0;
            int cId;
            Category category = cboCategory.SelectedItem as Category;
            if (category != null)
                cId = category.CId;
            else
            {
                MessageBox.Show("请选择项目", "出现错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = string.Empty;
            if (cId == 0)
            {
                // 添加项目类别名称的 SQL 语句
                sql = string.Format("INSERT INTO [Category](CategoryName,IsPayout)"
                    + "VALUES(N'{0}',{1})", name, isPayout);
            }
            else
            {
                // 添加项目名称的 SQL 语句
                sql = string.Format("INSERT INTO [Item](ItemName, CId)"
                    + "VALUES('N{0}',{1})", name, cId);
            }

            try
            {
                Login.conn.Open();
                Login.command.CommandText = sql;
                int count = Login.command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("添加类别/收支项成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtName.Focus();
                    tabControl1.SelectedTab = tabPage1;
                    // 当添加的是项目类别名称的时候，更新类别列表
                    if(cId == 0)
                        AddItems.UpdateCategory(this.cboCategory, (isPayout == 1));
                }
                else
                    MessageBox.Show("添加类别/收支项失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Login.conn.Close();
            }
        }

    }
}
