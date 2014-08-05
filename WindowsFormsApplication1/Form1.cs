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
            //枚举类型测试
            //MyEnum x = MyEnum.f;
            //MyEnum y = (MyEnum)202;
            //string result = "枚举数x的值为" + (int)x;
            //result += "\n枚举数y代表枚举元素" + y;
            //lblShow.Text = result;

            ////算数运算符的应用测试
            //int i = 1, j = 1, p, q;
            //p = (i++) + (i++) + (i++);
            //q = (++j) + (++j) + (++j);
            //lblShow.Text = "变量i的值为" + i;
            //lblShow.Text += "\n变量j的值为" + j;
            //lblShow.Text += "\n变量p的值为" + p;
            //lblShow.Text += "\n变量q的值为" + q;

            // 赋值运算符及隐式数据类型转换测试
            int a, b = 5;
            char c = '啊';
            a = c;
            float x = 42;
            x /= b;
            lblShow.Text = "整形变量a的值为" + a;
            lblShow.Text += "\n浮点型变量x的值为" + x;
        }

        private void lblShow_Move(object sender, EventArgs e)
        {

        }
    }
}
