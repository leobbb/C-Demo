using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchHighestScore
{
    public partial class Form1 : Form
    {
        // 添加学生成绩信息，然后显示出最高分和该生的姓名。
        public Form1()
        {
            InitializeComponent();
        }

        //使用结构体数组存储信息
        Student[] stu = new Student[10];
        int i = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0 || txtScore.Text.Trim().Length == 0)
            {
                lblAdd.Text = "输入错误！请重新输入。";
            }
            else
            {
                stu[i].Name = txtName.Text.Trim();
                stu[i].score = float.Parse(txtScore.Text.Trim());
                lblAdd.Text = string.Format("添加成功！共添加 {0} 个人。", ++i);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student rst = SearchHS(stu);
            lblSearch.Text = String.Format("成绩最高分为 {0} ,学生的姓名为 {1} 。", rst.score, rst.Name);
        }

        // 使用foreach语句查询最高分
        private Student SearchHS(Student[] stu)
        {
            Student  test = new Student();
            test.Name = "No Person";
            test.score = -1;

            foreach(Student p in stu){
                if (p.score > test.score)
                {
                    test.Name = p.Name;
                    test.score = p.score;
                }
            }
            return test;
        }


    }
}
