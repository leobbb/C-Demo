using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IPlayer iplayer;

        private void btnMP3_Click(object sender, EventArgs e)
        {
            iplayer = new MP3();
        }

        private void btnAVI_Click(object sender, EventArgs e)
        {
            iplayer = new Avi();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (iplayer  != null)
            {
                lblShow.Text = iplayer.Pre();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (iplayer != null)
            {
                lblShow.Text = iplayer.Stop();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (iplayer != null)
                lblShow.Text = iplayer.Play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (iplayer != null)
                lblShow.Text = iplayer.Pause();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (iplayer != null)
                lblShow.Text = iplayer.Next();
        }


    }
}
