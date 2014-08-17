namespace Test6._3
{
    partial class Form1
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
            this.lblShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPupil = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnUndergradute = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 29);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(164, 183);
            this.lblShow.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(73, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnPupil
            // 
            this.btnPupil.Location = new System.Drawing.Point(230, 69);
            this.btnPupil.Name = "btnPupil";
            this.btnPupil.Size = new System.Drawing.Size(75, 23);
            this.btnPupil.TabIndex = 3;
            this.btnPupil.Text = "添加小学生";
            this.btnPupil.UseVisualStyleBackColor = true;
            this.btnPupil.Click += new System.EventHandler(this.btnPupil_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.Location = new System.Drawing.Point(230, 108);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(75, 23);
            this.btnMiddle.TabIndex = 3;
            this.btnMiddle.Text = "添加中学生";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnUndergradute
            // 
            this.btnUndergradute.Location = new System.Drawing.Point(230, 147);
            this.btnUndergradute.Name = "btnUndergradute";
            this.btnUndergradute.Size = new System.Drawing.Size(75, 23);
            this.btnUndergradute.TabIndex = 3;
            this.btnUndergradute.Text = "添加大学生";
            this.btnUndergradute.UseVisualStyleBackColor = true;
            this.btnUndergradute.Click += new System.EventHandler(this.btnUndergradute_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(230, 189);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "查询全部";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 261);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnUndergradute);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnPupil);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShow);
            this.Name = "Form1";
            this.Text = "测试泛型类";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPupil;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnUndergradute;
        private System.Windows.Forms.Button btnCheck;
    }
}