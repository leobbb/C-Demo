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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsbAlter = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDone = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab1lsbShow = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tab1txtShow = new System.Windows.Forms.TextBox();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.tab2btnClear = new System.Windows.Forms.Button();
            this.tab2btnAdd = new System.Windows.Forms.Button();
            this.tab2Pwd = new System.Windows.Forms.TextBox();
            this.tab2Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.tabAlter = new System.Windows.Forms.TabPage();
            this.tab3lblShow = new System.Windows.Forms.Label();
            this.tab3btnSearch = new System.Windows.Forms.Button();
            this.tab3OldName = new System.Windows.Forms.TextBox();
            this.tab3btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tab3NewPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab3btnAlter = new System.Windows.Forms.Button();
            this.tab3NewName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tab1tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tab1tsmDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.tabAlter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            // tssDone
            // 
            this.tssDone.Name = "tssDone";
            this.tssDone.Size = new System.Drawing.Size(405, 17);
            this.tssDone.Spring = true;
            // 
            // tab1lsbShow
            // 
            this.tab1lsbShow.ContextMenuStrip = this.contextMenuStrip1;
            this.tab1lsbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab1lsbShow.FormattingEnabled = true;
            this.tab1lsbShow.ItemHeight = 20;
            this.tab1lsbShow.Location = new System.Drawing.Point(50, 48);
            this.tab1lsbShow.Margin = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.tab1lsbShow.Name = "tab1lsbShow";
            this.tab1lsbShow.Size = new System.Drawing.Size(320, 204);
            this.tab1lsbShow.TabIndex = 1;
            this.tab1lsbShow.DoubleClick += new System.EventHandler(this.tab1lsbShow_DoubleClick);
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
            this.tabInfo.Controls.Add(this.tab1txtShow);
            this.tabInfo.Controls.Add(this.tab1lsbShow);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(445, 295);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "查看用户信息";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tab1txtShow
            // 
            this.tab1txtShow.BackColor = System.Drawing.SystemColors.Window;
            this.tab1txtShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tab1txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab1txtShow.Location = new System.Drawing.Point(50, 19);
            this.tab1txtShow.Name = "tab1txtShow";
            this.tab1txtShow.ReadOnly = true;
            this.tab1txtShow.ShortcutsEnabled = false;
            this.tab1txtShow.Size = new System.Drawing.Size(319, 20);
            this.tab1txtShow.TabIndex = 2;
            this.tab1txtShow.Text = "15451";
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
            this.tabAddUser.Click += new System.EventHandler(this.tabAddUser_Click);
            this.tabAddUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabAddUser_MouseDown);
            this.tabAddUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabAddUser_MouseUp);
            // 
            // tab2btnClear
            // 
            this.tab2btnClear.Location = new System.Drawing.Point(244, 180);
            this.tab2btnClear.Name = "tab2btnClear";
            this.tab2btnClear.Size = new System.Drawing.Size(75, 23);
            this.tab2btnClear.TabIndex = 3;
            this.tab2btnClear.Text = "清空";
            this.tab2btnClear.UseVisualStyleBackColor = true;
            this.tab2btnClear.Click += new System.EventHandler(this.tab2btnClear_Click);
            // 
            // tab2btnAdd
            // 
            this.tab2btnAdd.Location = new System.Drawing.Point(119, 180);
            this.tab2btnAdd.Name = "tab2btnAdd";
            this.tab2btnAdd.Size = new System.Drawing.Size(75, 23);
            this.tab2btnAdd.TabIndex = 2;
            this.tab2btnAdd.Text = "添加（&A）";
            this.tab2btnAdd.UseVisualStyleBackColor = true;
            this.tab2btnAdd.Click += new System.EventHandler(this.tab2btnAdd_Click);
            // 
            // tab2Pwd
            // 
            this.tab2Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab2Pwd.Location = new System.Drawing.Point(159, 129);
            this.tab2Pwd.MaxLength = 50;
            this.tab2Pwd.Name = "tab2Pwd";
            this.tab2Pwd.Size = new System.Drawing.Size(143, 26);
            this.tab2Pwd.TabIndex = 1;
            this.tab2Pwd.UseSystemPasswordChar = true;
            this.tab2Pwd.WordWrap = false;
            // 
            // tab2Name
            // 
            this.tab2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab2Name.Location = new System.Drawing.Point(159, 91);
            this.tab2Name.MaxLength = 50;
            this.tab2Name.Name = "tab2Name";
            this.tab2Name.Size = new System.Drawing.Size(143, 26);
            this.tab2Name.TabIndex = 0;
            this.tab2Name.TextChanged += new System.EventHandler(this.tab2Name_TextChanged);
            this.tab2Name.Leave += new System.EventHandler(this.tab2Name_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(85, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "密    码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(85, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(100, 37);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(219, 24);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "请分别输入用户名和密码";
            // 
            // tabAlter
            // 
            this.tabAlter.Controls.Add(this.tab3lblShow);
            this.tabAlter.Controls.Add(this.tab3btnSearch);
            this.tabAlter.Controls.Add(this.tab3OldName);
            this.tabAlter.Controls.Add(this.tab3btnBack);
            this.tabAlter.Controls.Add(this.label5);
            this.tabAlter.Controls.Add(this.panel1);
            this.tabAlter.Location = new System.Drawing.Point(4, 22);
            this.tabAlter.Name = "tabAlter";
            this.tabAlter.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlter.Size = new System.Drawing.Size(445, 295);
            this.tabAlter.TabIndex = 2;
            this.tabAlter.Text = "修改用户信息";
            this.tabAlter.UseVisualStyleBackColor = true;
            // 
            // tab3lblShow
            // 
            this.tab3lblShow.AutoSize = true;
            this.tab3lblShow.Location = new System.Drawing.Point(123, 97);
            this.tab3lblShow.Name = "tab3lblShow";
            this.tab3lblShow.Size = new System.Drawing.Size(0, 13);
            this.tab3lblShow.TabIndex = 11;
            // 
            // tab3btnSearch
            // 
            this.tab3btnSearch.Location = new System.Drawing.Point(214, 65);
            this.tab3btnSearch.Name = "tab3btnSearch";
            this.tab3btnSearch.Size = new System.Drawing.Size(75, 23);
            this.tab3btnSearch.TabIndex = 12;
            this.tab3btnSearch.Text = "查询（&S）";
            this.tab3btnSearch.UseVisualStyleBackColor = true;
            this.tab3btnSearch.Click += new System.EventHandler(this.tab3btnSearch_Click);
            // 
            // tab3OldName
            // 
            this.tab3OldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab3OldName.Location = new System.Drawing.Point(239, 23);
            this.tab3OldName.Name = "tab3OldName";
            this.tab3OldName.Size = new System.Drawing.Size(143, 26);
            this.tab3OldName.TabIndex = 11;
            this.tab3OldName.TextChanged += new System.EventHandler(this.tab3OldName_TextChanged);
            // 
            // tab3btnBack
            // 
            this.tab3btnBack.Location = new System.Drawing.Point(320, 65);
            this.tab3btnBack.Name = "tab3btnBack";
            this.tab3btnBack.Size = new System.Drawing.Size(75, 23);
            this.tab3btnBack.TabIndex = 10;
            this.tab3btnBack.Text = "返回";
            this.tab3btnBack.UseVisualStyleBackColor = true;
            this.tab3btnBack.Click += new System.EventHandler(this.tab3btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "需要修改信息的用户名：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tab3NewPwd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tab3btnAlter);
            this.panel1.Controls.Add(this.tab3NewName);
            this.panel1.Location = new System.Drawing.Point(8, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 176);
            this.panel1.TabIndex = 13;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "提示：输入需要修改的信息，不修改的信息直接留空。";
            // 
            // tab3NewPwd
            // 
            this.tab3NewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab3NewPwd.Location = new System.Drawing.Point(189, 56);
            this.tab3NewPwd.MaxLength = 50;
            this.tab3NewPwd.Name = "tab3NewPwd";
            this.tab3NewPwd.Size = new System.Drawing.Size(143, 26);
            this.tab3NewPwd.TabIndex = 6;
            this.tab3NewPwd.UseSystemPasswordChar = true;
            this.tab3NewPwd.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(115, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "密    码：";
            // 
            // tab3btnAlter
            // 
            this.tab3btnAlter.Location = new System.Drawing.Point(189, 109);
            this.tab3btnAlter.Name = "tab3btnAlter";
            this.tab3btnAlter.Size = new System.Drawing.Size(75, 23);
            this.tab3btnAlter.TabIndex = 8;
            this.tab3btnAlter.Text = "确认（&Y）";
            this.tab3btnAlter.UseVisualStyleBackColor = true;
            this.tab3btnAlter.Click += new System.EventHandler(this.tab3btnAlter_Click);
            // 
            // tab3NewName
            // 
            this.tab3NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab3NewName.Location = new System.Drawing.Point(189, 18);
            this.tab3NewName.MaxLength = 50;
            this.tab3NewName.Name = "tab3NewName";
            this.tab3NewName.Size = new System.Drawing.Size(143, 26);
            this.tab3NewName.TabIndex = 4;
            this.tab3NewName.TextChanged += new System.EventHandler(this.tab3NewName_TextChanged);
            this.tab3NewName.Leave += new System.EventHandler(this.tab3NewName_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1tsmEdit,
            this.toolStripSeparator2,
            this.tab1tsmDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 54);
            // 
            // tab1tsmEdit
            // 
            this.tab1tsmEdit.Name = "tab1tsmEdit";
            this.tab1tsmEdit.Size = new System.Drawing.Size(152, 22);
            this.tab1tsmEdit.Text = "修改信息";
            this.tab1tsmEdit.Click += new System.EventHandler(this.tab1tsmEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // tab1tsmDel
            // 
            this.tab1tsmDel.Name = "tab1tsmDel";
            this.tab1tsmDel.Size = new System.Drawing.Size(152, 22);
            this.tab1tsmDel.Text = "删除";
            this.tab1tsmDel.Click += new System.EventHandler(this.tab1tsmDel_Click);
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
            this.tabAlter.ResumeLayout(false);
            this.tabAlter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tab1txtShow;
        private System.Windows.Forms.Button tab3btnBack;
        private System.Windows.Forms.Button tab3btnAlter;
        private System.Windows.Forms.TextBox tab3NewPwd;
        private System.Windows.Forms.TextBox tab3NewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tab3OldName;
        private System.Windows.Forms.Button tab3btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tab3lblShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tab1tsmEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tab1tsmDel;

    }
}