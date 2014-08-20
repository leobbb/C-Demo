namespace Test8._1
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDescSort = new System.Windows.Forms.Button();
            this.btnAscSort = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "排序前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "排序后";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(143, 57);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "生成数组";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDescSort
            // 
            this.btnDescSort.Location = new System.Drawing.Point(143, 104);
            this.btnDescSort.Name = "btnDescSort";
            this.btnDescSort.Size = new System.Drawing.Size(75, 23);
            this.btnDescSort.TabIndex = 1;
            this.btnDescSort.Text = "降序排序";
            this.btnDescSort.UseVisualStyleBackColor = true;
            this.btnDescSort.Click += new System.EventHandler(this.btnDescSort_Click);
            // 
            // btnAscSort
            // 
            this.btnAscSort.Location = new System.Drawing.Point(143, 152);
            this.btnAscSort.Name = "btnAscSort";
            this.btnAscSort.Size = new System.Drawing.Size(75, 23);
            this.btnAscSort.TabIndex = 1;
            this.btnAscSort.Text = "升序排序";
            this.btnAscSort.UseVisualStyleBackColor = true;
            this.btnAscSort.Click += new System.EventHandler(this.btnAscSort_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(21, 57);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(62, 149);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(274, 59);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(63, 147);
            this.txtTarget.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 258);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnAscSort);
            this.Controls.Add(this.btnDescSort);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "随机数组排序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDescSort;
        private System.Windows.Forms.Button btnAscSort;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
    }
}

