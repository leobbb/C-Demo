using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Contacter[] persons = new Contacter[10];

      
        int i = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            persons[i].Name = txtName.Text;
            persons[i].Telphone = txtTel.Text;
            ++i;
            lblShow.Text = "成功添加一个联系人";
            lblShow.Text += String.Format("\n现在共添加 {0} 个联系人", i);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isSearched = false;
            foreach (Contacter c in persons)
            {
                if (c.Name == txtSearch.Text.Trim())
                {
                    isSearched = true;
                    lblShow.Text += "\n 查找成功！ 此人的电话号码为：" + c.Telphone;
                }
            }
            if (!isSearched)
            {
                lblShow.Text += "\n 查无此人！";
            }
        }


    }

    struct Contacter
    {
        public string Name;
        public string Telphone;
    }
}
