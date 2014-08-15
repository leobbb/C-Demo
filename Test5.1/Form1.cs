using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPupil_Click(object sender, EventArgs e)
        {
            Student pup = new Pupil(txtName.Text.Trim(), int.Parse(txtAge.Text.Trim()),
                double.Parse(txtChinese.Text.Trim()), double.Parse(txtMath.Text.Trim()));
            lblShow.Text += string.Format("总人数： {0}，姓名： {1}，小学生，平均成绩为： ", Student.number, pup.Name);
            lblShow.Text += Convert.ToString(pup.Average()) + "\n";

        }

        private void btnMiddleSS_Click(object sender, EventArgs e)
        {
            Student middleS = new MiddleStudent(txtName.Text.Trim(), int.Parse(txtAge.Text.Trim()), double.Parse(txtChinese.Text.Trim()),
                double.Parse(txtMath.Text.Trim()), double.Parse(txtEnglish.Text.Trim()));
            lblShow.Text += string.Format("总人数： {0}, 姓名： {1}, 中学生，平均成绩为： ",Student.number,middleS.Name);
            lblShow.Text += Convert.ToString(middleS.Average()) + "\n";

        }

        private void btnUndergraduate_Click(object sender, EventArgs e)
        {
            Student underGS = new UnderGradute(txtName.Text.Trim(), int.Parse(txtAge.Text.Trim()), 
                double.Parse(txtChinese.Text.Trim()), double.Parse(txtMath.Text.Trim()));
            lblShow.Text += string.Format("总人数： {0}, 姓名： {1}， 大学生， 平均成绩： ", Student.number, underGS.Name);
            lblShow.Text += Convert.ToString(underGS.Average()) + "\n";
        }


    }
}
