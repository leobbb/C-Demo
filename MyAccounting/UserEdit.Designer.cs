namespace MyAccounting
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsbAlter = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab1lblShow = new System.Windows.Forms.Label();
            this.tssDone = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab1lsbShow = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.tabAlter = new System.Windows.Forms.TabPage();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab2Name = new System.Windows.Forms.TextBox();
            this.tab2Pwd = new System.Windows.Forms.TextBox();
            this.tab2btnAdd = new System.Windows.Forms.Button();
            this.tab2btnClear = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInfo,
            this.toolStripSeparator1,
            this.tsbAddUser,
            this.tsbAlter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(453, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInfo
            // 
            this.tsbInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbInfo.Image")));
            this.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfo.Name = "tsbInfo";
            this.tsbInfo.Size = new System.Drawing.Size(105, 22);
            this.tsbInfo.Text = "浏览用户信息";
            this.tsbInfo.CheckedChanged += new System.EventHandler(this.tsbInfo_Checked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddUser
            // 
            this.tsbAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddUser.Image")));
            this.tsbAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddUser.Name = "tsbAddUser";
            this.tsbAddUser.Size = new System.Drawing.Size(79, 22);
            this.tsbAddUser.Text = "添加用户";
            // 
            // tsbAlter
            // 
            this.tsbAlter.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlter.Image")));
            this.tsbAlter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlter.Name = "tsbAlter";
            this.tsbAlter.Size = new System.Drawing.Size(105, 22);
            this.tsbAlter.Text = "修改用户信息";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssDone});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(453, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(33, 17);
            this.tssStatus.Text = "就绪";
            // 
            // tab1lblShow
            // 
            this.tab1lblShow.AutoSize = true;
            this.tab1lblShow.Location = new System.Drawing.Point(47, 21);
            this.tab1lblShow.Name = "tab1lblShow";
            this.tab1lblShow.Size = new System.Drawing.Size(35, 13);
            this.tab1lblShow.TabIndex = 0;
            this.tab1lblShow.Text = "label1";
            // 
            // tssDone
            // 
            this.tssDone.Name = "tssDone";
            this.tssDone.Size = new System.Drawing.Size(405, 17);
            this.tssDone.Spring = true;
            // 
            // tab1lsbShow
            // 
            this.tab1lsbShow.FormattingEnabled = true;
            this.tab1lsbShow.Location = new System.Drawing.Point(50, 48);
            this.tab1lsbShow.Name = "tab1lsbShow";
            this.tab1lsbShow.Size = new System.Drawing.Size(320, 212);
            this.tab1lsbShow.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabAddUser);
            this.tabControl1.Controls.Add(this.tabAlter);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 321);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tab1lsbShow);
            this.tabInfo.Controls.Add(this.tab1lblShow);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(445, 295);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "查看用户信息";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.tab2btnClear);
            this.tabAddUser.Controls.Add(this.tab2btnAdd);
            this.tabAddUser.Controls.Add(this.tab2Pwd);
            this.tabAddUser.Controls.Add(this.tab2Name);
            this.tabAddUser.Controls.Add(this.label3);
            this.tabAddUser.Controls.Add(this.label2);
            this.tabAddUser.Controls.Add(this.lable1);
            this.tabAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(445, 295);
            this.tabAddUser.TabIndex = 1;
            this.tabAddUser.Text = "添加用户";
            this.tabAddUser.UseVisualStyleBackColor = true;
            // 
            // tabAlter
            // 
            this.tabAlter.Location = new System.Drawing.Point(4, 22);
            this.tabAlter.Name = "tabAlter";
            this.tabAlter.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlter.Size = new System.Drawing.Size(445, 295);
            this.tabAlter.TabIndex = 2;
            this.tabAlter.Text = "修改用户信息";
            this.tabAlter.UseVisualStyleBackColor = true;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(107, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(219, 24);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "请分别输入用户名和密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // tab2Name
            // 
            this.tab2Name.Location = new System.Drawing.Point(166, 77);
            this.tab2Name.MaxLength = 50;
            this.tab2Name.Name = "tab2Name";
            this.tab2Name.Size = new System.Drawing.Size(143, 20);
            this.tab2Name.TabIndex = 3;
            this.tab2Name.TextChanged += new System.EventHandler(this.tab2Name_TextChanged);
            this.tab2Name.Enter += new System.EventHandler(this.tab2Name_Enter);
            this.tab2Name.Leave += new System.EventHandler(this.tab2Name_Leave);
            // 
            // tab2Pwd
            // 
            this.tab2Pwd.Location = new System.Drawing.Point(166, 115);
            this.tab2Pwd.MaxLength = 50;
            this.tab2Pwd.Name = "tab2Pwd";
            this.tab2Pwd.Size = new System.Drawing.Size(143, 20);
            this.tab2Pwd.TabIndex = 3;
            this.tab2Pwd.UseSystemPasswordChar = true;
            this.tab2Pwd.WordWrap = false;
            this.tab2Pwd.Enter += new System.EventHandler(this.tab2Pwd_Enter);
            // 
            // tab2btnAdd
            // 
            this.tab2btnAdd.Location = new System.Drawing.Point(126, 166);
            this.tab2btnAdd.Name = "tab2btnAdd";
            this.tab2btnAdd.Size = new System.Drawing.Size(75, 23);
            this.tab2btnAdd.TabIndex = 4;
            this.tab2btnAdd.Text = "添加（&A）";
            this.tab2btnAdd.UseVisualStyleBackColor = true;
            this.tab2btnAdd.Click += new System.EventHandler(this.tab2btnAdd_Click);
            // 
            // tab2btnClear
            // 
            this.tab2btnClear.Location = new System.Drawing.Point(251, 166);
            this.tab2btnClear.Name = "tab2btnClear";
            this.tab2btnClear.Size = new System.Drawing.Size(75, 23);
            this.tab2btnClear.TabIndex = 5;
            this.tab2btnClear.Text = "清空";
            this.tab2btnClear.UseVisualStyleBackColor = true;
            this.tab2btnClear.Click += new System.EventHandler(this.tab2btnClear_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 366);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddUser;
        private System.Windows.Forms.ToolStripButton tsbAlter;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Label tab1lblShow;
        private System.Windows.Forms.ToolStripStatusLabel tssDone;
        private System.Windows.Forms.ListBox tab1lsbShow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.TabPage tabAlter;
        private System.Windows.Forms.Button tab2btnAdd;
        private System.Windows.Forms.TextBox tab2Pwd;
        private System.Windows.Forms.TextBox tab2Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button tab2btnClear;

    }
}