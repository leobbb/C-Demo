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

namespace Test12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Test12-2
        //private XmlTextWriter tw;

        //// 实例化 XmlTextWriter 对象，并开始写XML 文档
        //private void btnStart_Click(object sender, EventArgs e)
        //{
            //tw = new XmlTextWriter(@"Data\student.xml", Encoding.UTF8);
        //    tw.Formatting = Formatting.Indented;

        //    tw.WriteStartDocument();
        //    tw.WriteStartElement("学生列表");
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    tw.WriteStartElement("学生");  // “学生”元素开始
        //        tw.WriteAttributeString("类别", cmbType.SelectedText);    // “学生”元素的属性
        //        tw.WriteAttributeString("学号", txtNo.Text);              // “学生”元素的属性
        //        tw.WriteStartElement("姓名");     // “姓名”元素开始
        //            tw.WriteAttributeString("中文名", txtName.Text);       // “姓名”元素的属性
        //            tw.WriteAttributeString("英文名", txtEnName.Text);     // “姓名”元素的属性
        //        tw.WriteEndElement();            // “姓名”元素结束

        //    string sex = "";
        //    if (rdoMale.Checked)
        //        sex = rdoMale.Text;
        //    else
        //        sex = rdoFemale.Text;       

        //        tw.WriteElementString("性别", sex);           // “性别”元素
        //        tw.WriteElementString("电话", txtTel.Text);   // “电话”元素
        //    tw.WriteEndElement();       // “学生”元素结束

        //}

        //private void btnEnd_Click(object sender, EventArgs e)
        //{
        //    tw.WriteEndElement();
        //    tw.WriteEndDocument();
        //    tw.Close();
        //}
        #endregion 

        private XmlDocument xd;
        private XmlElement root;


        private void btnStart_Click(object sender, EventArgs e)
        {
            xd = new XmlDocument();
            XmlDeclaration declare = xd.CreateXmlDeclaration("1.0","","yes");
            xd.AppendChild(declare);
            root = xd.CreateElement("学生列表");
            xd.AppendChild(root);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            XmlElement student = xd.CreateElement("学生");
            XmlAttribute attr = xd.CreateAttribute("类别");
            attr.Value = cmbType.Text;
            student.Attributes.Append(attr);

            attr = xd.CreateAttribute("学号");
            attr.Value = txtNo.Text;
            student.Attributes.Append(attr);

            XmlElement elem = xd.CreateElement("姓名");
            attr = xd.CreateAttribute("中文名");
            attr.Value = txtName.Text;
            elem.Attributes.Append(attr);
            attr = xd.CreateAttribute("英文名");
            attr.Value = txtEnName.Text;
            elem.Attributes.Append(attr);
            student.AppendChild(elem);

            elem = xd.CreateElement("性别");
            string sex = string.Empty;
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            XmlText text = xd.CreateTextNode(sex);
            elem.AppendChild(text);
            student.AppendChild(elem);

            elem = xd.CreateElement("电话");
            text = xd.CreateTextNode(txtTel.Text);
            elem.AppendChild(text);
            student.AppendChild(elem);

            root.AppendChild(student);
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            xd.Save(@"Data\12-3student.xml");
        }
    }
}
