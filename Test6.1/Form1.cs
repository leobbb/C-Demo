using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Test6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList AlStudents = new ArrayList();
        private void Foreach()
        {
            foreach (object stuo in AlStudents)
            {
                Student stuFor = (Student)stuo;
                lblShow.Text += "\n" + stuFor.ShowMsg();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stuNo = Convert.ToInt32(txtStuNo.Text);
            Student stu = new Student(txtName.Text, stuNo);
            AlStudents.Add(stu);
            lblShow.Text = "";
            Foreach();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int stuNo = Convert.ToInt32(txtStuNo.Text);
            int index = Convert.ToInt32(txtIndex.Text);
            Student stu = new Student(txtName.Text, stuNo);
            AlStudents.Insert(index, stu);
            lblShow.Text = "";
            Foreach();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            Foreach();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);
            AlStudents.RemoveAt(index);
            lblShow.Text = "";
            Foreach();
        }
    }
}
