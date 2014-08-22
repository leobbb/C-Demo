namespace FontEdit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNum = new System.Windows.Forms.ComboBox();
            this.grbShape = new System.Windows.Forms.GroupBox();
            this.ckbDel = new System.Windows.Forms.CheckBox();
            this.ckbIta = new System.Windows.Forms.CheckBox();
            this.ckbUnd = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.grbName = new System.Windows.Forms.GroupBox();
            this.rdbBla = new System.Windows.Forms.RadioButton();
            this.rdbKai = new System.Windows.Forms.RadioButton();
            this.rdbLis = new System.Windows.Forms.RadioButton();
            this.rdbSong = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.rdbCBla = new System.Windows.Forms.RadioButton();
            this.rdbCRed = new System.Windows.Forms.RadioButton();
            this.rdbCGre = new System.Windows.Forms.RadioButton();
            this.rdbCBlu = new System.Windows.Forms.RadioButton();
            this.grbShape.SuspendLayout();
            this.grbName.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtBox
            // 
            this.rtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtBox.Location = new System.Drawing.Point(12, 12);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.Size = new System.Drawing.Size(315, 412);
            this.rtxtBox.TabIndex = 0;
            this.rtxtBox.Text = "在此处输入任意文字测试字体设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "字体字号：";
            // 
            // cmbNum
            // 
            this.cmbNum.Location = new System.Drawing.Point(422, 24);
            this.cmbNum.Name = "cmbNum";
            this.cmbNum.Size = new System.Drawing.Size(121, 21);
            this.cmbNum.TabIndex = 2;
            this.cmbNum.SelectedIndexChanged += new System.EventHandler(this.cmbNum_SelectedIndexChanged);
            // 
            // grbShape
            // 
            this.grbShape.Controls.Add(this.ckbDel);
            this.grbShape.Controls.Add(this.ckbIta);
            this.grbShape.Controls.Add(this.ckbUnd);
            this.grbShape.Controls.Add(this.ckbBold);
            this.grbShape.Location = new System.Drawing.Point(343, 62);
            this.grbShape.Name = "grbShape";
            this.grbShape.Size = new System.Drawing.Size(200, 100);
            this.grbShape.TabIndex = 3;
            this.grbShape.TabStop = false;
            this.grbShape.Text = "字形与效果";
            // 
            // ckbDel
            // 
            this.ckbDel.AutoSize = true;
            this.ckbDel.Location = new System.Drawing.Point(109, 63);
            this.ckbDel.Name = "ckbDel";
            this.ckbDel.Size = new System.Drawing.Size(62, 17);
            this.ckbDel.TabIndex = 0;
            this.ckbDel.Text = "删除线";
            this.ckbDel.UseVisualStyleBackColor = true;
            this.ckbDel.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbIta
            // 
            this.ckbIta.AutoSize = true;
            this.ckbIta.Location = new System.Drawing.Point(109, 30);
            this.ckbIta.Name = "ckbIta";
            this.ckbIta.Size = new System.Drawing.Size(50, 17);
            this.ckbIta.TabIndex = 0;
            this.ckbIta.Text = "斜体";
            this.ckbIta.UseVisualStyleBackColor = true;
            this.ckbIta.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbUnd
            // 
            this.ckbUnd.AutoSize = true;
            this.ckbUnd.Location = new System.Drawing.Point(23, 63);
            this.ckbUnd.Name = "ckbUnd";
            this.ckbUnd.Size = new System.Drawing.Size(62, 17);
            this.ckbUnd.TabIndex = 0;
            this.ckbUnd.Text = "下划线";
            this.ckbUnd.UseVisualStyleBackColor = true;
            this.ckbUnd.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Location = new System.Drawing.Point(23, 30);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(50, 17);
            this.ckbBold.TabIndex = 0;
            this.ckbBold.Text = "粗体";
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // grbName
            // 
            this.grbName.Controls.Add(this.rdbBla);
            this.grbName.Controls.Add(this.rdbKai);
            this.grbName.Controls.Add(this.rdbLis);
            this.grbName.Controls.Add(this.rdbSong);
            this.grbName.Location = new System.Drawing.Point(343, 191);
            this.grbName.Name = "grbName";
            this.grbName.Size = new System.Drawing.Size(200, 100);
            this.grbName.TabIndex = 3;
            this.grbName.TabStop = false;
            this.grbName.Text = "字体名称";
            // 
            // rdbBla
            // 
            this.rdbBla.AutoSize = true;
            this.rdbBla.Location = new System.Drawing.Point(109, 64);
            this.rdbBla.Name = "rdbBla";
            this.rdbBla.Size = new System.Drawing.Size(49, 17);
            this.rdbBla.TabIndex = 0;
            this.rdbBla.TabStop = true;
            this.rdbBla.Text = "黑体";
            this.rdbBla.UseVisualStyleBackColor = true;
            this.rdbBla.CheckedChanged += new System.EventHandler(this.rdbSong_CheckedChanged);
            // 
            // rdbKai
            // 
            this.rdbKai.AutoSize = true;
            this.rdbKai.Location = new System.Drawing.Point(109, 30);
            this.rdbKai.Name = "rdbKai";
            this.rdbKai.Size = new System.Drawing.Size(49, 17);
            this.rdbKai.TabIndex = 0;
            this.rdbKai.TabStop = true;
            this.rdbKai.Text = "楷体";
            this.rdbKai.UseVisualStyleBackColor = true;
            this.rdbKai.CheckedChanged += new System.EventHandler(this.rdbSong_CheckedChanged);
            // 
            // rdbLis
            // 
            this.rdbLis.AutoSize = true;
            this.rdbLis.Location = new System.Drawing.Point(23, 64);
            this.rdbLis.Name = "rdbLis";
            this.rdbLis.Size = new System.Drawing.Size(49, 17);
            this.rdbLis.TabIndex = 0;
            this.rdbLis.TabStop = true;
            this.rdbLis.Text = "隶书";
            this.rdbLis.UseVisualStyleBackColor = true;
            this.rdbLis.CheckedChanged += new System.EventHandler(this.rdbSong_CheckedChanged);
            // 
            // rdbSong
            // 
            this.rdbSong.AutoSize = true;
            this.rdbSong.Location = new System.Drawing.Point(23, 30);
            this.rdbSong.Name = "rdbSong";
            this.rdbSong.Size = new System.Drawing.Size(49, 17);
            this.rdbSong.TabIndex = 0;
            this.rdbSong.TabStop = true;
            this.rdbSong.Text = "宋体";
            this.rdbSong.UseVisualStyleBackColor = true;
            this.rdbSong.CheckedChanged += new System.EventHandler(this.rdbSong_CheckedChanged);
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.rdbCBla);
            this.grbColor.Controls.Add(this.rdbCRed);
            this.grbColor.Controls.Add(this.rdbCGre);
            this.grbColor.Controls.Add(this.rdbCBlu);
            this.grbColor.Location = new System.Drawing.Point(343, 324);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(200, 100);
            this.grbColor.TabIndex = 3;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "字体颜色";
            // 
            // rdbCBla
            // 
            this.rdbCBla.AutoSize = true;
            this.rdbCBla.Location = new System.Drawing.Point(109, 65);
            this.rdbCBla.Name = "rdbCBla";
            this.rdbCBla.Size = new System.Drawing.Size(49, 17);
            this.rdbCBla.TabIndex = 0;
            this.rdbCBla.TabStop = true;
            this.rdbCBla.Text = "黑色";
            this.rdbCBla.UseVisualStyleBackColor = true;
            this.rdbCBla.CheckedChanged += new System.EventHandler(this.rdbCRed_CheckedChanged);
            // 
            // rdbCRed
            // 
            this.rdbCRed.AutoSize = true;
            this.rdbCRed.Location = new System.Drawing.Point(23, 31);
            this.rdbCRed.Name = "rdbCRed";
            this.rdbCRed.Size = new System.Drawing.Size(49, 17);
            this.rdbCRed.TabIndex = 0;
            this.rdbCRed.TabStop = true;
            this.rdbCRed.Text = "红色";
            this.rdbCRed.UseVisualStyleBackColor = true;
            this.rdbCRed.CheckedChanged += new System.EventHandler(this.rdbCRed_CheckedChanged);
            // 
            // rdbCGre
            // 
            this.rdbCGre.AutoSize = true;
            this.rdbCGre.Location = new System.Drawing.Point(109, 31);
            this.rdbCGre.Name = "rdbCGre";
            this.rdbCGre.Size = new System.Drawing.Size(49, 17);
            this.rdbCGre.TabIndex = 0;
            this.rdbCGre.TabStop = true;
            this.rdbCGre.Text = "绿色";
            this.rdbCGre.UseVisualStyleBackColor = true;
            this.rdbCGre.CheckedChanged += new System.EventHandler(this.rdbCRed_CheckedChanged);
            // 
            // rdbCBlu
            // 
            this.rdbCBlu.AutoSize = true;
            this.rdbCBlu.Location = new System.Drawing.Point(23, 65);
            this.rdbCBlu.Name = "rdbCBlu";
            this.rdbCBlu.Size = new System.Drawing.Size(49, 17);
            this.rdbCBlu.TabIndex = 0;
            this.rdbCBlu.TabStop = true;
            this.rdbCBlu.Text = "蓝色";
            this.rdbCBlu.UseVisualStyleBackColor = true;
            this.rdbCBlu.CheckedChanged += new System.EventHandler(this.rdbCRed_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 436);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.grbName);
            this.Controls.Add(this.grbShape);
            this.Controls.Add(this.cmbNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字体测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbShape.ResumeLayout(false);
            this.grbShape.PerformLayout();
            this.grbName.ResumeLayout(false);
            this.grbName.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNum;
        private System.Windows.Forms.GroupBox grbShape;
        private System.Windows.Forms.CheckBox ckbDel;
        private System.Windows.Forms.CheckBox ckbIta;
        private System.Windows.Forms.CheckBox ckbUnd;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.GroupBox grbName;
        private System.Windows.Forms.RadioButton rdbBla;
        private System.Windows.Forms.RadioButton rdbKai;
        private System.Windows.Forms.RadioButton rdbLis;
        private System.Windows.Forms.RadioButton rdbSong;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.RadioButton rdbCBla;
        private System.Windows.Forms.RadioButton rdbCRed;
        private System.Windows.Forms.RadioButton rdbCGre;
        private System.Windows.Forms.RadioButton rdbCBlu;
    }
}

