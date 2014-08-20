using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            school.subscribeEvent(g);
        }

        Grade g = new Grade();
        School school = new School();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtName.Text, Convert.ToChar(txtSex.Text));
            g.Add(s);
            lblShow.Text = txtName.Text + "成功报到！";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            g.ProcessRegister();
            lblShow.Text = "已成功注册的学生名单如下：\n";
            for (int i = 0; i < school.count; ++i)
            {
                lblShow.Text += String.Format("姓名：{0}，性别：{1}\n", school[i].name, school[i].sex.ToString());
            }
        }

       
    }
}
