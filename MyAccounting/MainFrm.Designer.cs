namespace MyAccounting
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddExp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddExp = new System.Windows.Forms.ToolStripButton();
            this.tsbStatistics = new System.Windows.Forms.ToolStripButton();
            this.tsbAddItems = new System.Windows.Forms.ToolStripButton();
            this.tsbtsmUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.EToolStripMenuItem,
            this.DToolStripMenuItem,
            this.HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripTextBox1.ShowShortcutKeys = false;
            this.toolStripTextBox1.Size = new System.Drawing.Size(103, 20);
            this.toolStripTextBox1.Text = "系统管理（&S）";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeyDisplayString = "";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.tsmExit.Size = new System.Drawing.Size(170, 22);
            this.tsmExit.Text = "退出（&X）";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // EToolStripMenuItem
            // 
            this.EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddExp,
            this.tsmStatistics});
            this.EToolStripMenuItem.Name = "EToolStripMenuItem";
            this.EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EToolStripMenuItem.ShowShortcutKeys = false;
            this.EToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.EToolStripMenuItem.Text = "收支管理（&E）";
            // 
            // tsmAddExp
            // 
            this.tsmAddExp.Name = "tsmAddExp";
            this.tsmAddExp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.tsmAddExp.Size = new System.Drawing.Size(198, 22);
            this.tsmAddExp.Text = "添加收支（&P）";
            // 
            // tsmStatistics
            // 
            this.tsmStatistics.Name = "tsmStatistics";
            this.tsmStatistics.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.tsmStatistics.Size = new System.Drawing.Size(198, 22);
            this.tsmStatistics.Text = "统计查询（&C）";
            // 
            // DToolStripMenuItem
            // 
            this.DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddItems,
            this.tsmUser});
            this.DToolStripMenuItem.Name = "DToolStripMenuItem";
            this.DToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.DToolStripMenuItem.ShowShortcutKeys = false;
            this.DToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.DToolStripMenuItem.Text = "基本资料（&D）";
            // 
            // tsmAddItems
            // 
            this.tsmAddItems.Name = "tsmAddItems";
            this.tsmAddItems.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.tsmAddItems.Size = new System.Drawing.Size(214, 22);
            this.tsmAddItems.Text = "添加收支项目（&I）";
            // 
            // tsmUser
            // 
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.tsmUser.Size = new System.Drawing.Size(214, 22);
            this.tsmUser.Text = "用户管理（&U）";
            // 
            // HToolStripMenuItem
            // 
            this.HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.HToolStripMenuItem.Name = "HToolStripMenuItem";
            this.HToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.HToolStripMenuItem.ShowShortcutKeys = false;
            this.HToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.tsmAbout.Size = new System.Drawing.Size(172, 22);
            this.tsmAbout.Text = "关于（&A）";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddExp,
            this.tsbStatistics,
            this.toolStripSeparator1,
            this.tsbAddItems,
            this.tsbtsmUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddExp
            // 
            this.tsbAddExp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddExp.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddExp.Image")));
            this.tsbAddExp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddExp.Name = "tsbAddExp";
            this.tsbAddExp.Size = new System.Drawing.Size(51, 22);
            this.tsbAddExp.Text = "AddExp";
            this.tsbAddExp.ToolTipText = "添加收支情况";
            // 
            // tsbStatistics
            // 
            this.tsbStatistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsbStatistics.Image")));
            this.tsbStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatistics.Name = "tsbStatistics";
            this.tsbStatistics.Size = new System.Drawing.Size(39, 22);
            this.tsbStatistics.Text = "Statis";
            this.tsbStatistics.ToolTipText = "收支统计和查询";
            // 
            // tsbAddItems
            // 
            this.tsbAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddItems.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddItems.Image")));
            this.tsbAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddItems.Name = "tsbAddItems";
            this.tsbAddItems.Size = new System.Drawing.Size(62, 22);
            this.tsbAddItems.Text = "AddItems";
            this.tsbAddItems.ToolTipText = "添加收支项目";
            // 
            // tsbtsmUser
            // 
            this.tsbtsmUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtsmUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbtsmUser.Image")));
            this.tsbtsmUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtsmUser.Name = "tsbtsmUser";
            this.tsbtsmUser.Size = new System.Drawing.Size(58, 22);
            this.tsbtsmUser.Text = "UserMan";
            this.tsbtsmUser.ToolTipText = "用户信息管理";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(33, 17);
            this.tssStatus.Text = "就绪";
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(603, 17);
            this.tssMsg.Spring = true;
            this.tssMsg.Text = "请选择一个操作";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "个人理财";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddExp;
        private System.Windows.Forms.ToolStripMenuItem tsmStatistics;
        private System.Windows.Forms.ToolStripMenuItem DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddItems;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddExp;
        private System.Windows.Forms.ToolStripButton tsbStatistics;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddItems;
        private System.Windows.Forms.ToolStripButton tsbtsmUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
    }
}