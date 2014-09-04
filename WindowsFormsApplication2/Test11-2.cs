using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication2
{
    public partial class Test11_2 : Form
    {
        public Test11_2()
        {
            InitializeComponent();
        }

        private void Test11_2_Load(object sender, EventArgs e)
        {

        }

        //#region Test 11-2
        //private void btnSave_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnShow_Click(object sender, EventArgs e)
        //{

        //}
        //#endregion
    
        #region Test 11-3

        [Serializable]
        public class Student
        {
            public int sno;
            public string name;
            public bool sex;
            public Student(int no, string nm, bool isMale)
            {
                this.sno = no;
                this.name = nm;
                this.sex = isMale;
            }
        }

        [Serializable]
        public class StudentList
        {
            private Student[] list = new Student[100];
            public Student this[int index]
            {
                get
                {
                    if (index < 0 || index >= 100)
                        return list[0];
                    else
                        return list[index];
                }
                set
                {
                    if (!(index < 0 || index >= 100))
                        list[index] = value;
                }
            }
        }

        private StudentList list = new StudentList();  // 生命一个学生列表
        private int i = 0;  // 标记即将加入列表中的学生，也代表学生的个数

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string file = @"Data\11-3student.dat";
                Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, list);                
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "写文件出错", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sno = Int32.Parse(txtNo.Text);
            bool isMale = rdoMale.Checked; // 单选按钮 “男”被选择，则值为 true。
            Student student = new Student(sno, txtName.Text, isMale);
            list[i] = student;
            ++i;          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            lstShow.Items.Add("学号\t姓名\t性别");
            string file = @"Data\11-3student.dat";
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            StudentList students = (StudentList)bf.Deserialize(stream);
            int k = 0;
            while (students[k] != null)
            {
                int s_no = students[k].sno;
                string name = students[k].name;
                bool isMale = students[k].sex;
                string sex = "";
                if (isMale)
                    sex = "男";
                else
                    sex = "女";
                string result = String.Format("{0}\t{1}\t{2}", s_no, name, sex);
                lstShow.Items.Add(result);
                ++k;
            }
            stream.Close();
        }

        #endregion
    }
}
