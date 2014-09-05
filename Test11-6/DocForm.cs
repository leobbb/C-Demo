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
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        // 公共属性，用来操作RichTextBox 控件。
        public RichTextBox Source
        {
            get { return txtSource; }
            set { txtSource = value; }
        }
    }
}
