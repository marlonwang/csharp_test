namespace Switchdegree
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHtoS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stBox1 = new System.Windows.Forms.TextBox();
            this.htBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStoH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.htBox2 = new System.Windows.Forms.TextBox();
            this.stBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControl11 = new TemControl.UserControl1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间区域";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHtoS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stBox1);
            this.groupBox1.Controls.Add(this.htBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "华氏转摄氏";
            // 
            // btnHtoS
            // 
            this.btnHtoS.Location = new System.Drawing.Point(245, 71);
            this.btnHtoS.Name = "btnHtoS";
            this.btnHtoS.Size = new System.Drawing.Size(58, 23);
            this.btnHtoS.TabIndex = 3;
            this.btnHtoS.Text = "转换";
            this.btnHtoS.UseVisualStyleBackColor = true;
            this.btnHtoS.Click += new System.EventHandler(this.btnHtoS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "-->";
            // 
            // stBox1
            // 
            this.stBox1.Location = new System.Drawing.Point(203, 32);
            this.stBox1.Name = "stBox1";
            this.stBox1.Size = new System.Drawing.Size(100, 21);
            this.stBox1.TabIndex = 1;
            // 
            // htBox1
            // 
            this.htBox1.Location = new System.Drawing.Point(21, 32);
            this.htBox1.Name = "htBox1";
            this.htBox1.Size = new System.Drawing.Size(100, 21);
            this.htBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStoH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.htBox2);
            this.groupBox2.Controls.Add(this.stBox2);
            this.groupBox2.Location = new System.Drawing.Point(15, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "摄氏转华氏";
            // 
            // btnStoH
            // 
            this.btnStoH.Location = new System.Drawing.Point(245, 69);
            this.btnStoH.Name = "btnStoH";
            this.btnStoH.Size = new System.Drawing.Size(58, 23);
            this.btnStoH.TabIndex = 3;
            this.btnStoH.Text = "转换";
            this.btnStoH.UseVisualStyleBackColor = true;
            this.btnStoH.Click += new System.EventHandler(this.btnStoH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "-->";
            // 
            // htBox2
            // 
            this.htBox2.Location = new System.Drawing.Point(203, 36);
            this.htBox2.Name = "htBox2";
            this.htBox2.Size = new System.Drawing.Size(100, 21);
            this.htBox2.TabIndex = 1;
            // 
            // stBox2
            // 
            this.stBox2.Location = new System.Drawing.Point(21, 35);
            this.stBox2.Name = "stBox2";
            this.stBox2.Size = new System.Drawing.Size(100, 21);
            this.stBox2.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(378, 48);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(198, 198);
            this.userControl11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 266);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "温度转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stBox1;
        private System.Windows.Forms.TextBox htBox1;
        private System.Windows.Forms.Button btnHtoS;
        private System.Windows.Forms.Button btnStoH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox htBox2;
        private System.Windows.Forms.TextBox stBox2;
        private System.Windows.Forms.Timer timer1;
        private TemControl.UserControl1 userControl11;
    }
}

