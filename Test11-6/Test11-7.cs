using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test11_7
{
    public partial class Test11_7 : Form
    {
        public Test11_7()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private int wCount = 0;
        private string initialPos = "";
        private DocForm doc;

        // 新建文档
        private void newFile_Click(object sender, EventArgs e)
        {
            ++wCount;
            doc = new DocForm();
            doc.MdiParent = this;
            doc.Text = "文档-" + wCount;
            doc.Show();
        }
        // 设置打开或保存文档的默认路径
        private void optionMenu_Click(object sender, EventArgs e)
        {
            SetDialog dlg = new SetDialog();
            dlg.ShowDialog();
            initialPos = dlg.docPosition;
            dlg.Close();
            openFileDialog1.InitialDirectory = initialPos;
            saveFileDialog1.InitialDirectory = initialPos;
        }

        // 打开文档
        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RichTextBoxStreamType fileType;
                switch (openFileDialog1.FilterIndex)
                {
                    case 1:
                        fileType = RichTextBoxStreamType.PlainText;
                        break;
                    case 2:
                        fileType = RichTextBoxStreamType.RichText;
                        break;
                    default:
                        fileType = RichTextBoxStreamType.UnicodePlainText; 
                        break;

                }
                ++wCount;
                doc = new DocForm();
                doc.MdiParent = this;
                doc.Text = openFileDialog1.FileName;
                doc.Source.LoadFile(openFileDialog1.FileName, fileType);
                doc.Show();
            }
        }

        // 保存文档
        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RichTextBoxStreamType fileType;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        fileType = RichTextBoxStreamType.PlainText;
                        break;
                    case 2:
                        fileType = RichTextBoxStreamType.RichText;
                        break;
                    default:
                        fileType = RichTextBoxStreamType.UnicodePlainText;
                        break;
                }

                doc.Source.SaveFile(saveFileDialog1.FileName, fileType);
            }
        }

        // 修改“文档”窗口已选中的文字的字体
        private void fontMenu_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && doc != null)
                doc.Source.SelectionFont = fontDialog1.Font;
        }

        // 修改“文档”窗口已选中的文字的颜色
        private void colorMenu_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && doc != null)
                doc.Source.SelectionColor = colorDialog1.Color;
        }

        private void closeFile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


    }
}
