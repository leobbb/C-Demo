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
            // 添加类别信息
            AddExpenditure.CategoryChange(this.cboCategory, this.rdoIncome);
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
            string item = txtName.Text.Trim();
            // 项目所属类别
            string name = cboCategory.SelectedItem.ToString();
            // 类别的分类（收入或者支出，1 为支出）
            int isPayout = rdoExpenditure.Checked?1:0;

            // 通过Login 类里的静态函数 ConnectSql 建立连接对象
            SqlConnection conn = Login.ConnectSql();

            string sql = string.Format("INSERT INTO [Category]([CategoryName],[CategoryItem], [IsPayout])" + "VALUES('{0}','{1}',{2})", name, item, isPayout);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("添加类别成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtName.Focus();
                    tabControl1.SelectedTab = tabPage1;
                }
                else
                    MessageBox.Show("添加类别失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
