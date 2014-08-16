namespace Test6_4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 18);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(179, 169);
            this.lblShow.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "名字";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(238, 68);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(75, 23);
            this.btnDog.TabIndex = 2;
            this.btnDog.Text = "添加狗";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(238, 97);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "添加小狗";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(238, 135);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "添加猫";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(238, 164);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 2;
            this.btnFeed.Text = "喂食";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 223);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnFeed;
    }
}

