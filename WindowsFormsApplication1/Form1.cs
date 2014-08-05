using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum MyEnum { a = 101, b, c, d = 201, e, f };
        private void Test_Load(object sender, EventArgs e)
        {
            MyEnum x = MyEnum.f;
            MyEnum y = (MyEnum)202;
            string result = "枚举数x的值为" + (int)x;
            result += "\n枚举数y代表枚举元素" + y;
            lblShow.Text = result;
        }

        private void lblShow_Move(object sender, EventArgs e)
        {

        }
    }
}
