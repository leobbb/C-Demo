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
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private void rdoExpenditure_CheckedChanged(object sender, EventArgs e)
        {
            AddExpenditure.CategoryChange(this.cboCategory, this.rdoIncome);
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
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

    }
}
