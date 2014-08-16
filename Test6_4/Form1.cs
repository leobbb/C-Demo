using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pet<Animal> myPet = new Pet<Animal>();

        private void btnDog_Click(object sender, EventArgs e)
        {
            myPet.Animal.Add(new Dog(txtName.Text));
            lblShow.Text += string.Format("\n 添加Dog:{0} 成功", txtName.Text);
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            myPet.Animal.Add(new SmallDog(txtName.Text));
            lblShow.Text += string.Format("\n 添加SmallDog: {0} 成功", txtName.Text);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            myPet.Animal.Add(new Cat(txtName.Text));
            lblShow.Text += string.Format("\n 添加Cat: {0} 成功", txtName.Text);
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            lblShow.Text = myPet.FeedTheAnimals();
        }
    }
}
