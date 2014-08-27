using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounting
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }


        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAddExp_Click(object sender, EventArgs e)
        {
            AddExpenditure addExpFrm = new AddExpenditure();
            
            addExpFrm.MinimizeBox = false;
            addExpFrm.WindowState = FormWindowState.Maximized;
            addExpFrm.MdiParent = this;
            addExpFrm.Show();
            tssMsg.Text = addExpFrm.Text;
        }

        private void tsmAddItems_Click(object sender, EventArgs e)
        {
            AddItems addItmFrm = new AddItems();
            addItmFrm.MdiParent = this;
            addItmFrm.Show();
            tssMsg.Text = addItmFrm.Text;
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            About aboFrm = new About();
            aboFrm.MdiParent = this;
            aboFrm.Show();
            tssMsg.Text = aboFrm.Text;
        }


    }
}
