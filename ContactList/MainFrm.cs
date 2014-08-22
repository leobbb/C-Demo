using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void tsmCreateNew_Click(object sender, EventArgs e)
        {
            NewContact nfrm = new NewContact();
            nfrm.MdiParent = this;
            nfrm.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
