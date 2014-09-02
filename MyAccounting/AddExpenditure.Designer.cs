namespace MyAccounting
{
    partial class AddExpenditure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.rdoExpenditure = new System.Windows.Forms.RadioButton();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.chkOwn = new System.Windows.Forms.CheckBox();
            this.chkFamily = new System.Windows.Forms.CheckBox();
            this.chkRelative = new System.Windows.Forms.CheckBox();
            this.chkFriend = new System.Windows.Forms.CheckBox();
            this.chkColleague = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "收支类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "收支类别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "收支项目：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "备       注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "日    期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "说    明：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "收支人：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "金    额：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存（&S）";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(417, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消（&S）";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(112, 32);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(49, 17);
            this.rdoIncome.TabIndex = 6;
            this.rdoIncome.Text = "收入";
            this.rdoIncome.UseVisualStyleBackColor = true;
            this.rdoIncome.CheckedChanged += new System.EventHandler(this.rdoIncome_CheckedChanged);
            // 
            // rdoExpenditure
            // 
            this.rdoExpenditure.AutoSize = true;
            this.rdoExpenditure.Location = new System.Drawing.Point(202, 32);
            this.rdoExpenditure.Name = "rdoExpenditure";
            this.rdoExpenditure.Size = new System.Drawing.Size(49, 17);
            this.rdoExpenditure.TabIndex = 7;
            this.rdoExpenditure.Text = "支出";
            this.rdoExpenditure.UseVisualStyleBackColor = true;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "生活消费",
            "固定资产",
            "休闲娱乐",
            "医疗药品",
            "教育培训",
            "其他支出"});
            this.cboCategory.Location = new System.Drawing.Point(112, 64);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(175, 21);
            this.cboCategory.TabIndex = 8;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(112, 103);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(175, 95);
            this.lstItem.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(387, 28);
            this.dtpDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(387, 64);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(200, 20);
            this.txtExplain.TabIndex = 11;
            // 
            // chkOwn
            // 
            this.chkOwn.AutoSize = true;
            this.chkOwn.Location = new System.Drawing.Point(387, 102);
            this.chkOwn.Name = "chkOwn";
            this.chkOwn.Size = new System.Drawing.Size(38, 17);
            this.chkOwn.TabIndex = 12;
            this.chkOwn.Text = "我";
            this.chkOwn.UseVisualStyleBackColor = true;
            // 
            // chkFamily
            // 
            this.chkFamily.AutoSize = true;
            this.chkFamily.Location = new System.Drawing.Point(451, 102);
            this.chkFamily.Name = "chkFamily";
            this.chkFamily.Size = new System.Drawing.Size(50, 17);
            this.chkFamily.TabIndex = 13;
            this.chkFamily.Text = "家人";
            this.chkFamily.UseVisualStyleBackColor = true;
            // 
            // chkRelative
            // 
            this.chkRelative.AutoSize = true;
            this.chkRelative.Location = new System.Drawing.Point(528, 102);
            this.chkRelative.Name = "chkRelative";
            this.chkRelative.Size = new System.Drawing.Size(50, 17);
            this.chkRelative.TabIndex = 14;
            this.chkRelative.Text = "亲戚";
            this.chkRelative.UseVisualStyleBackColor = true;
            // 
            // chkFriend
            // 
            this.chkFriend.AutoSize = true;
            this.chkFriend.Location = new System.Drawing.Point(387, 136);
            this.chkFriend.Name = "chkFriend";
            this.chkFriend.Size = new System.Drawing.Size(50, 17);
            this.chkFriend.TabIndex = 12;
            this.chkFriend.Text = "朋友";
            this.chkFriend.UseVisualStyleBackColor = true;
            // 
            // chkColleague
            // 
            this.chkColleague.AutoSize = true;
            this.chkColleague.Location = new System.Drawing.Point(451, 136);
            this.chkColleague.Name = "chkColleague";
            this.chkColleague.Size = new System.Drawing.Size(50, 17);
            this.chkColleague.TabIndex = 13;
            this.chkColleague.Text = "同事";
            this.chkColleague.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(528, 136);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(50, 17);
            this.chkOther.TabIndex = 14;
            this.chkOther.Text = "其它";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(387, 169);
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(200, 20);
            this.numAmount.TabIndex = 15;
            this.numAmount.ThousandsSeparator = true;
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(112, 213);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(475, 145);
            this.rtxtRemarks.TabIndex = 16;
            this.rtxtRemarks.Text = "";
            // 
            // AddExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 466);
            this.Controls.Add(this.rtxtRemarks);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkRelative);
            this.Controls.Add(this.chkColleague);
            this.Controls.Add(this.chkFamily);
            this.Controls.Add(this.chkFriend);
            this.Controls.Add(this.chkOwn);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.rdoExpenditure);
            this.Controls.Add(this.rdoIncome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddExpenditure";
            this.Text = "收支情况记录";
            this.Load += new System.EventHandler(this.AddExpenditure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoIncome;
        private System.Windows.Forms.RadioButton rdoExpenditure;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.CheckBox chkOwn;
        private System.Windows.Forms.CheckBox chkFamily;
        private System.Windows.Forms.CheckBox chkRelative;
        private System.Windows.Forms.CheckBox chkFriend;
        private System.Windows.Forms.CheckBox chkColleague;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
    }
}