using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6._2
{
    public partial class Form1 : Form
    {

        ClassList classList;

        public Form1()
        {
            InitializeComponent();
            classList = new ClassList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sno = txtSno.Text.Trim();
            string sna = txtName.Text.Trim();

            classList.Add(sno, sna);

            lblShow.Text = string.Format("学生 {0} 添加成功！", sno);
            lblShow.Text += string.Format("\n班级中共有 {0} 个学生", classList.Count());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIndex.Text.Trim() == string.Empty)
                {
                    lblShow.Text = string.Format("班级中共有 {0} 个学生\n\n{1}",
                        classList.Count(), classList.GetAll());
                }
                else
                {
                    int index = Convert.ToInt32(txtIndex.Text.Trim());
                    lblShow.Text = string.Format("第 {0} 个学生的信息为：\n{1}",
                        index, classList[index - 1].ShowMsg());
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                index = Convert.ToInt32(txtIndex.Text.Trim());
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message + "\n请输入正确的索引值");
                return;
            }
            try
            {
                lblShow.Text = string.Format("第 {0} 个学生的信息为：\n {1}",
                index, classList[index - 1].ShowMsg());
            
                classList.DeleteAt(index-1);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
                return;
            }

            lblShow.Text += string.Format(" \n已删除。\n班级中还有学生 {0} 个", classList.Count());
        }
    }
}
