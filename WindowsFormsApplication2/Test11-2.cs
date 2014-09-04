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
    public partial class Test11_2 : Form
    {
        public Test11_2()
        {
            InitializeComponent();
        }

        private void Test11_2_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"Data\student.dat", FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Int32.Parse(txtNo.Text));
                bw.Write(txtName.Text);
                bool isMale;
                if (rdoMale.Checked)
                    isMale = true;
                else
                    isMale = false;
                bw.Write(isMale);
                fs.Flush();
                fs.Close();
                bw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "写文件出错", MessageBoxButtons.OK);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            lstShow.Items.Add("学号\t姓名\t性别");
            FileStream fs = new FileStream(@"Data\student.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            fs.Position = 0;
            while (fs.Position != fs.Length)
            {
                int stuNO = br.ReadInt32();
                string stuName = br.ReadString();
                string sex = "";
                if (br.ReadBoolean())
                    sex = "男";
                else
                    sex = "女";

                string result = string.Format("{0}\t{1}\t{2}", stuNO, stuName, sex);
                lstShow.Items.Add(result);
            }
            br.Close();
            fs.Close();
        }
    }
}
