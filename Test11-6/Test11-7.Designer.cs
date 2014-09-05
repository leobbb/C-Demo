namespace Test11_7
{
    partial class Test11_7
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.formatMenu,
            this.toolMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(534, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.saveFile,
            this.closeFile});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(77, 20);
            this.fileMenu.Text = "文件（&F）";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(152, 22);
            this.newFile.Text = "新建";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(152, 22);
            this.openFile.Text = "打开";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(152, 22);
            this.saveFile.Text = "保存";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // closeFile
            // 
            this.closeFile.Name = "closeFile";
            this.closeFile.Size = new System.Drawing.Size(152, 22);
            this.closeFile.Text = "关闭";
            this.closeFile.Click += new System.EventHandler(this.closeFile_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenu,
            this.colorMenu});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(80, 20);
            this.formatMenu.Text = "格式（&O）";
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(152, 22);
            this.fontMenu.Text = "字体";
            this.fontMenu.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(152, 22);
            this.colorMenu.Text = "颜色";
            this.colorMenu.Click += new System.EventHandler(this.colorMenu_Click);
            // 
            // toolMenu
            // 
            this.toolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionMenu});
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(45, 20);
            this.toolMenu.Text = "工具";
            // 
            // optionMenu
            // 
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(152, 22);
            this.optionMenu.Text = "选项";
            this.optionMenu.Click += new System.EventHandler(this.optionMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文件|*.txt|RTF文件|*.rft|所有文件|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文件|*.txt|RTF文件|*.rft|所有文件|*.*";
            // 
            // Test11_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 358);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Test11_7";
            this.Text = "Test11_6";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem closeFile;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem toolMenu;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripMenuItem colorMenu;
        private System.Windows.Forms.ToolStripMenuItem optionMenu;
    }
}