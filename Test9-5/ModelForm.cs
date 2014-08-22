using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test9_5
{
    public partial class ModelForm : Form
    {
        public ModelForm(string msg)
        {
            InitializeComponent();
            this.message = msg;
        }

        private string message;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            lblShow.Text = message;
            
        }
    }
}
