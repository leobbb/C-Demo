using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6._3
{
    public partial class Form1 : Form
    {

        ClassList<Student> cList;

        public Form1()
        {
            InitializeComponent();
            cList = new ClassList<Student>();
        }

        private void btnPupil_Click(object sender, EventArgs e)
        {
            Student pup = new Pupil(txtName.Text.Trim());
            cList.Add(pup);
            lblShow.Text = "成功添加一名小学生的信息。";
            lblShow.Text += string.Format("\n\n现在班级里共有 {0} 个人。", cList.Count());
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            Student mid = new MiddleStudent(txtName.Text.Trim());
            cList.Add(mid);
            lblShow.Text = "成功添加一名中学生的信息。";
            lblShow.Text += string.Format("\n\n现在班级里共有 {0} 个人。", cList.Count());
        }

        private void btnUndergradute_Click(object sender, EventArgs e)
        {
            Student und = new UnderGradute(txtName.Text.Trim());
            cList.Add(und);
            lblShow.Text = "成功添加一名大学生的信息。";
            lblShow.Text += string.Format("\n\n现在班级里共有 {0} 个人。", cList.Count());
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblShow.Text = string.Format("\n当前班级里有 {0} 个人", cList.Count());
            lblShow.Text += string.Format("\n{0}", cList.GetAll());
        }

    }
}
