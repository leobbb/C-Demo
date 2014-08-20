namespace Test8_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入数据";
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(30, 82);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(329, 53);
            this.lblShow.TabIndex = 0;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(103, 30);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(187, 20);
            this.txtSource.TabIndex = 1;
            this.txtSource.Text = "在此，可输入字符。";
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            this.txtSource.Enter += new System.EventHandler(this.txtSource_Enter);
            this.txtSource.Leave += new System.EventHandler(this.txtSource_Leave);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(305, 28);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(54, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 180);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "字符串输入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnOk;
    }
}

