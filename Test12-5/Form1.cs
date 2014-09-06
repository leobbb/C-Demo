using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Test12_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private XmlDocument doc;
        private XmlElement root;
        private int current = 1;

        private void ShowStudent(int i)
        {
            XmlNodeList a = root.GetElementsByTagName("学生");
            XmlElement student = (XmlElement)a[i];
            txtType.Text = student.Attributes["类别"].Value;
            txtNo.Text = student.Attributes["学号"].Value;
            txtName.Text = student.ChildNodes[0].Attributes["中文名"].Value;
            txtEnName.Text = student.ChildNodes[0].Attributes["英文名"].Value;
            txtSex.Text = student.ChildNodes[1].InnerText;
            txtTel.Text = student.ChildNodes[2].InnerText;
        }

        private XmlElement CreateStudent()
        {
            XmlElement student = doc.CreateElement("学生");
            XmlAttribute attr = doc.CreateAttribute("类别");
            attr.Value = txtType.Text;
            student.Attributes.Append(attr);

            attr = doc.CreateAttribute("学号");
            attr.Value = txtNo.Text;
            student.Attributes.Append(attr);
            

            XmlElement elem = doc.CreateElement("姓名");
            attr = doc.CreateAttribute("中文名");
            attr.Value = txtName.Text;
            elem.Attributes.Append(attr);
            attr = doc.CreateAttribute("英文名");
            attr.Value = txtEnName.Text;
            elem.Attributes.Append(attr);
            student.AppendChild(elem);

            elem = doc.CreateElement("性别");
            string sex = txtSex.Text;
            XmlText text = doc.CreateTextNode(sex);
            elem.AppendChild(text);
            student.AppendChild(elem);

            elem = doc.CreateElement("电话");
            text = doc.CreateTextNode(txtTel.Text);
            elem.AppendChild(text);
            student.AppendChild(elem);

            return student;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            doc.Load(@"Data\student.xml");
            root = doc.DocumentElement;
            ShowStudent(0);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (current > 1)
            {
                --current;
                ShowStudent(current - 1);
            }
            else
                MessageBox.Show("已经是第一个了。");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current < root.ChildNodes.Count)
            {
                ++current;
                ShowStudent(current - 1);
            }
            else
                MessageBox.Show("已经是最好一个了");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            root.AppendChild(CreateStudent());
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            XmlNode newChild = (XmlNode)CreateStudent();
            root.ReplaceChild(newChild, root.ChildNodes[current - 1]);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            root.RemoveChild(root.ChildNodes[current - 1]);
            ShowStudent(current - 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.Save(@"Data\student.xml");
        }

    }
}
