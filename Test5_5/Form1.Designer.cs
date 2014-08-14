namespace Test5_5
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
            this.btnGlobe = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGlobe
            // 
            this.btnGlobe.Location = new System.Drawing.Point(53, 229);
            this.btnGlobe.Name = "btnGlobe";
            this.btnGlobe.Size = new System.Drawing.Size(75, 23);
            this.btnGlobe.TabIndex = 0;
            this.btnGlobe.Text = "圆球";
            this.btnGlobe.UseVisualStyleBackColor = true;
            this.btnGlobe.Click += new System.EventHandler(this.btnGlobe_Click);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(198, 229);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(75, 23);
            this.btnCone.TabIndex = 1;
            this.btnCone.Text = "圆锥";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // btnCylinder
            // 
            this.btnCylinder.Location = new System.Drawing.Point(345, 229);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(75, 23);
            this.btnCylinder.TabIndex = 2;
            this.btnCylinder.Text = "圆柱";
            this.btnCylinder.UseVisualStyleBackColor = true;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "半径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "高";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(91, 41);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 5;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(296, 41);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(100, 20);
            this.txtHigh.TabIndex = 6;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(50, 94);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(370, 81);
            this.lblShow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 290);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.btnGlobe);
            this.Name = "Form1";
            this.Text = "计算立体图形体积";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGlobe;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Button btnCylinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label lblShow;
    }
}

