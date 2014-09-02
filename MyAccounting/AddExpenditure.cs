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
    public partial class AddExpenditure : Form
    {
        public AddExpenditure()
        {
            InitializeComponent();
        }

        private void rdoIncome_CheckedChanged(object sender, EventArgs e)
        {
            //CategoryChange(this.cboCategory,this.rdoIncome);
            AddItems.UpdateCategory(this.cboCategory, this.rdoExpenditure.Checked);
            cboCategory.Items.RemoveAt(0);
            cboCategory.SelectedIndex = 0;
        }

        //internal static void CategoryChange(ComboBox cbo,RadioButton rdo)
        //{
        //    cbo.Items.Clear();
        //    if (rdo.Checked == true)
        //    {
        //        cbo.Items.Add("工作收入");
        //        cbo.Items.Add("投资收益");
        //        cbo.Items.Add("其他收入");
        //    }
        //    else
        //    {
        //        cbo.Items.Add("生活消费");
        //        cbo.Items.Add("固定资产");
        //        cbo.Items.Add("休闲娱乐");
        //        cbo.Items.Add("医疗药品");
        //        cbo.Items.Add("教育培训");
        //        cbo.Items.Add("其他支出");
        //    }
        //    cbo.SelectedIndex = 0;
        //}

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstItem.Items.Clear();
            int cId = 0;
            Category category = cboCategory.SelectedItem as Category;
            if (category != null) cId = category.CId;

            // 选择指定类别编号的收支项
            string sql = string.Format("SELECT * FROM [Item] WHERE [CId] = {0}", cId);
            try
            {
                Login.conn.Open();
                Login.command.CommandText = sql;

                Login.dataReader = Login.command.ExecuteReader();

                while (Login.dataReader.Read())
                {
                    int iId = (int)Login.dataReader["ItemId"];
                    string name = Login.dataReader["ItemName"].ToString().Trim();
                    lstItem.Items.Add(new Item(cId, iId, name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Login.dataReader.Close();
                Login.conn.Close();
            }

            //switch (cboCategory.SelectedItem.ToString())
            //{
            //    case "生活消费":
            //        lstItem.Items.Add("餐饮");
            //        lstItem.Items.Add("生活用品");
            //        lstItem.Items.Add("交通费");
            //        lstItem.Items.Add("水电气");
            //        lstItem.Items.Add("水果蔬菜");
            //        lstItem.SelectedIndex = 2;
            //        break;
            //    case "固定资产":
            //        lstItem.Items.Add("家用电器");
            //        lstItem.Items.Add("服装");
            //        break;
            //    case "休闲娱乐":
            //        lstItem.Items.AddRange(new object[] { "旅游度假", "腐败聚会" });
            //        break;
            //    case "医疗药品":
            //        lstItem.Items.AddRange(new object[] { "药品费", "住院费", "护理费" });
            //        lstItem.SelectedIndex = 2;
            //        break;
            //    case "教育培训":
            //        lstItem.Items.Add("进修费");
            //        lstItem.Items.Add("教材费");
            //        lstItem.Items.Add("数码装备");
            //        lstItem.SelectedIndex = 2;
            //        break;
            //    case "工作收入":
            //        lstItem.Items.AddRange(new object[] { "工资", "兼职", "奖金" });
            //        lstItem.SelectedIndex = 1;
            //        break;
            //    case "投资收益":
            //        lstItem.Items.Add("利息");
            //        break;
            //    default:
            //        lstItem.Items.Add("无");
            //        break;
            //}
            //if (lstItem.SelectedIndex < 0) 
            //{
            //    lstItem.SelectedIndex = 0;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iId = 0, cId = 0;
            Item item = lstItem.SelectedItem as Item;
            if (item != null)
            {
                cId = item.CId;
                iId = item.IId;
            }
            decimal amount = numAmount.Value;       // 金额
            DateTime date = dtpDate.Value;          // 日期
            string explain = txtExplain.Text;       // 说明
            string sql = string.Format("INSERT INTO [List]([CId],[ItemId], [Amount],[TradeDate],[Explain]) VALUES " +
                "({0},{1},{2},'{3}',N'{4}')", cId, iId, amount, date, explain);
            try
            {
                Login.command.CommandText = sql;
                Login.conn.Open();
                int count = Login.command.ExecuteNonQuery();
                if (count > 0)
                    MessageBox.Show("添加收支明细成功。", "添加成功", MessageBoxButtons.OK);
                else
                    MessageBox.Show("添加收支明细失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Login.conn.Close();
            }

            //rtxtRemarks.Clear();
            //rtxtRemarks.AppendText("要保存的信息为: \n");
            //rtxtRemarks.AppendText(cboCategory.SelectedItem.ToString());
            //rtxtRemarks.AppendText("-");
            //rtxtRemarks.AppendText(lstItem.SelectedItem.ToString() + "\n日期：");
            //rtxtRemarks.AppendText(dtpDate.Value.ToLongDateString()+"\n说明：");
            //rtxtRemarks.AppendText(txtExplain.Text + "\n收支人：");
            //if (chkOwn.Checked) rtxtRemarks.AppendText(chkOwn.Text + "  ");
            //if (chkFamily.Checked) rtxtRemarks.AppendText(chkFamily.Text + "  ");
            //if (chkRelative.Checked) rtxtRemarks.AppendText(chkRelative.Text + "  ");
            //if (chkFriend.Checked) rtxtRemarks.AppendText(chkFriend.Text + "  ");
            //if (chkColleague.Checked) rtxtRemarks.AppendText(chkColleague.Text + "  ");
            //if (chkOther.Checked) rtxtRemarks.AppendText(chkOther.Text + "  ");
            //rtxtRemarks.AppendText("\n金额：");
            //rtxtRemarks.AppendText(numAmount.Value.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExpenditure_Load(object sender, EventArgs e)
        {
            this.rdoIncome.Checked = true;
        }

    }
}
