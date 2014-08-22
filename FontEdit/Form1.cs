using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Font font;

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle1, fontStyle2, fontStyle3, fontStyle4;
            fontStyle1 = FontStyle.Regular;
            fontStyle2 = FontStyle.Regular;
            fontStyle3 = FontStyle.Regular;
            fontStyle4 = FontStyle.Regular;
            if (ckbBold.Checked)
            {
                fontStyle1 = FontStyle.Bold;
            }
            if (ckbIta.Checked)
            {
                fontStyle2 = FontStyle.Italic;
            }
            if (ckbDel.Checked)
            {
                fontStyle3 = FontStyle.Strikeout;
            }
            if (ckbUnd.Checked)
            {
                fontStyle4 = FontStyle.Underline;
            }
            font = new Font(font, fontStyle1 | fontStyle2 | fontStyle3 | fontStyle4);
            rtxtBox.Font = font;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNum.Items.Clear();
            for (int i = 5; i <= 72; i += 3)
            {
                cmbNum.Items.Add(i);
            }
            font = rtxtBox.Font;
            cmbNum.Text = font.Size.ToString();
        }

        private void rdbSong_CheckedChanged(object sender, EventArgs e)
        {
            string fontFamily = font.FontFamily.Name;
            if (rdbSong.Checked)
                fontFamily = rdbSong.Text;
            else 
                if (rdbKai.Checked) fontFamily = rdbKai.Text;
            else 
                if (rdbLis.Checked) fontFamily = rdbLis.Text;
            else 
                if (rdbBla.Checked) fontFamily = rdbBla.Text;
            font = new Font(fontFamily, font.Size, font.Style);
            rtxtBox.Font = font;

        }

        private void rdbCRed_CheckedChanged(object sender, EventArgs e)
        {
            Color color = rtxtBox.ForeColor;
            if (rdbCRed.Checked)
                color = Color.Red;
            else if (rdbCGre.Checked)
                color = Color.Green;
            else if (rdbCBlu.Checked)
                color = Color.Blue;
            else if (rdbCBla.Checked)
                color = Color.Black;
            rtxtBox.ForeColor = color;
        }

        private void cmbNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(cmbNum.Text);
            font = new Font(font.FontFamily, size);
            rtxtBox.Font = font;
        }
    }
}
