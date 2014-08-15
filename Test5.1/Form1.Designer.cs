namespace Test5._1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnPupil = new System.Windows.Forms.Button();
            this.btnMiddleSS = new System.Windows.Forms.Button();
            this.btnUndergraduate = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "年龄";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(69, 73);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "语文/必修课";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "数学/选修课";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(262, 27);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 20);
            this.txtChinese.TabIndex = 1;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(262, 73);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 20);
            this.txtMath.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "英语";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(262, 123);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish.TabIndex = 3;
            // 
            // btnPupil
            // 
            this.btnPupil.Location = new System.Drawing.Point(391, 25);
            this.btnPupil.Name = "btnPupil";
            this.btnPupil.Size = new System.Drawing.Size(75, 23);
            this.btnPupil.TabIndex = 4;
            this.btnPupil.Text = "小学生";
            this.btnPupil.UseVisualStyleBackColor = true;
            this.btnPupil.Click += new System.EventHandler(this.btnPupil_Click);
            // 
            // btnMiddleSS
            // 
            this.btnMiddleSS.Location = new System.Drawing.Point(391, 71);
            this.btnMiddleSS.Name = "btnMiddleSS";
            this.btnMiddleSS.Size = new System.Drawing.Size(75, 23);
            this.btnMiddleSS.TabIndex = 5;
            this.btnMiddleSS.Text = "中学生";
            this.btnMiddleSS.UseVisualStyleBackColor = true;
            this.btnMiddleSS.Click += new System.EventHandler(this.btnMiddleSS_Click);
            // 
            // btnUndergraduate
            // 
            this.btnUndergraduate.Location = new System.Drawing.Point(391, 121);
            this.btnUndergraduate.Name = "btnUndergraduate";
            this.btnUndergraduate.Size = new System.Drawing.Size(75, 23);
            this.btnUndergraduate.TabIndex = 6;
            this.btnUndergraduate.Text = "大学生";
            this.btnUndergraduate.UseVisualStyleBackColor = true;
            this.btnUndergraduate.Click += new System.EventHandler(this.btnUndergraduate_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(28, 166);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(418, 96);
            this.lblShow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 290);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnUndergraduate);
            this.Controls.Add(this.btnMiddleSS);
            this.Controls.Add(this.btnPupil);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "学生管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnPupil;
        private System.Windows.Forms.Button btnMiddleSS;
        private System.Windows.Forms.Button btnUndergraduate;
        private System.Windows.Forms.Label lblShow;
    }
}

