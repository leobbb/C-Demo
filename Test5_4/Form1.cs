using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCtBase_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            Animal a = new SmallDog();
            AnimalEat(a);
        }

        private void AnimalEat(Animal a)
        {
            lblShow.Text = a.Eat();
        }

        private void btnCtChild_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            Dog d = new Dog(txtName.Text, age, txtType.Text);
            AnimalEat(d);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = "贝贝";
            txtAge.Text = "2";
            txtType.Text = "吉娃娃";
        }
    }
}
