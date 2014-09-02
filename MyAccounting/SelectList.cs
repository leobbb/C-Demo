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
    public partial class SelectList : Form
    {
        

        public SelectList()
        {
            InitializeComponent();
        }


        private void SelectList_Load(object sender, EventArgs e)
        {
            cboKey.Items.AddRange(new object[] { "收支项", "类别", "说明", "金额", "日期" });
            try
            {
                cboKey.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "加载出错", MessageBoxButtons.OK);
            }
        }

        private void cboKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            txtValue1.Text = txtValue2.Text = "";
            if (key == "金额" || key == "日期")
                txtValue2.Enabled = true;
            else
                txtValue2.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string key = cboKey.SelectedItem.ToString();
            string value1 = txtValue1.Text.Trim();
            string condition = "";
            switch (key)
            {
                case "收支项":
                    condition = string.Format("and c.ItemName like N'%{0}%'", value1);
                    break;
                case "类别":
                    condition = string.Format("and b.CategoryName like N'%{0}%'", value1);
                    break;
                case "说明":
                    condition = string.Format("and a.Explain like N'%{0}%'", value1);
                    break;
                case "金额":
                    condition = string.Format("and a.Amount between '{0}' and '{1}' ", value1, txtValue2.Text.Trim());
                    break;
                case "日期":
                    condition = string.Format("and a.TradeDate between '{0}' and '{1}'", value1, txtValue2.Text.Trim());
                    break;
            }

            string sql = "SELECT [a].[LId] AS ID, [c].[ItemName] AS 收支项, [b].[CategoryName] AS 类别," +
                "[b].[IsPayout] AS 是否支出, [a].[TradeDate] as 收支日期, [a].[Amount] AS 金额, [a].[Explain] AS 说明" +
                "  FROM [List] AS [a],[Category] AS [b], [Item] AS [c] WHERE [a].[ItemId]= [c].[ItemId] AND [c].[CId] = " +
                "[b].[CId] " + condition;
            SqlDataAdapter dataAdapter;
            DataSet dataSet;
            try
            {
                dataAdapter = new SqlDataAdapter(sql, Login.conn);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvList.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作出错", MessageBoxButtons.OK);
            }
            finally
            {
                
            }
            
        }
    }
}
