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

namespace WindowsFormsApplication2
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

        private void btnSave_Click(object sender, EventArgs e)
        {           
            try
            {                
                StreamWriter sw = new StreamWriter(@"Data\blog.txt", true);
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine(txtSource.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                txtShow.Text = ex.Message;
            }            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"Data\blog.txt");
                txtShow.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch(Exception ex)
            {
                txtShow.Text = ex.Message;
            }
        }
    }
}
