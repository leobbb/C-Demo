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
        // 程序的字段
        private AddItems addItems;
        private AddExpenditure addExp;
        private About about;
        private SelectList selectList;
        private UserEdit userEdit;

        public MainFrm()
        {
            InitializeComponent();
            addExp = new AddExpenditure();
            addItems = new AddItems();
            about = new About();
            userEdit = new UserEdit();
            selectList = new SelectList();
        }


        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAddExp_Click(object sender, EventArgs e)
        {
            addExp.MinimizeBox = false;
            addExp.WindowState = FormWindowState.Maximized;
            addExp.MdiParent = this;
            addExp.Show();
            tssMsg.Text = addExp.Text;
        }

        private void tsmAddItems_Click(object sender, EventArgs e)
        {            
            addItems.MdiParent = this;
            addItems.Show();
            tssMsg.Text = addItems.Text;
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {         
            about.MdiParent = this;
            about.Show();
            tssMsg.Text = about.Text;
        }

        private void tsbtsmUser_Click(object sender, EventArgs e)
        {
            userEdit.MdiParent = this;
            userEdit.Show();
            tssMsg.Text = userEdit.Text;
        }

        private void tsbStatistics_Click(object sender, EventArgs e)
        {
            selectList.MdiParent = this;
            selectList.Show();
            tssMsg.Text = selectList.Text;
        }
    }
}
