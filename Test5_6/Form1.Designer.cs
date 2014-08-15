namespace Test5_6
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
            this.lblShow = new System.Windows.Forms.Label();
            this.btnMp3 = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(46, 34);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(215, 76);
            this.lblShow.TabIndex = 0;
            // 
            // btnMp3
            // 
            this.btnMp3.Location = new System.Drawing.Point(46, 136);
            this.btnMp3.Name = "btnMp3";
            this.btnMp3.Size = new System.Drawing.Size(75, 23);
            this.btnMp3.TabIndex = 1;
            this.btnMp3.Text = "MP3";
            this.btnMp3.UseVisualStyleBackColor = true;
            this.btnMp3.Click += new System.EventHandler(this.btnMp3_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(195, 136);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(75, 23);
            this.btnPhone.TabIndex = 2;
            this.btnPhone.Text = "手机";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 201);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnMp3);
            this.Controls.Add(this.lblShow);
            this.Name = "Form1";
            this.Text = "接口应用测试";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnMp3;
        private System.Windows.Forms.Button btnPhone;
    }
}

