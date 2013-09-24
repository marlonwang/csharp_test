namespace ClassTemperature
{
    partial class DegreeSwitch
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHtoS = new System.Windows.Forms.Button();
            this.stBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.htBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStoH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.htBox2 = new System.Windows.Forms.TextBox();
            this.stBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHtoS);
            this.groupBox1.Controls.Add(this.stBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.htBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "华氏转摄氏";
            // 
            // btnHtoS
            // 
            this.btnHtoS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHtoS.Location = new System.Drawing.Point(239, 69);
            this.btnHtoS.Name = "btnHtoS";
            this.btnHtoS.Size = new System.Drawing.Size(61, 23);
            this.btnHtoS.TabIndex = 3;
            this.btnHtoS.Text = "转换";
            this.btnHtoS.UseVisualStyleBackColor = true;
            this.btnHtoS.Click += new System.EventHandler(this.btnHtoS_Click);
            // 
            // stBox1
            // 
            this.stBox1.Location = new System.Drawing.Point(199, 31);
            this.stBox1.Name = "stBox1";
            this.stBox1.Size = new System.Drawing.Size(100, 21);
            this.stBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "-->";
            // 
            // htBox1
            // 
            this.htBox1.Location = new System.Drawing.Point(10, 32);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "摄氏转华氏";
            // 
            // btnStoH
            // 
            this.btnStoH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStoH.Location = new System.Drawing.Point(239, 69);
            this.btnStoH.Name = "btnStoH";
            this.btnStoH.Size = new System.Drawing.Size(61, 23);
            this.btnStoH.TabIndex = 6;
            this.btnStoH.Text = "转换";
            this.btnStoH.UseVisualStyleBackColor = true;
            this.btnStoH.Click += new System.EventHandler(this.btnStoH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "-->";
            // 
            // htBox2
            // 
            this.htBox2.Location = new System.Drawing.Point(199, 31);
            this.htBox2.Name = "htBox2";
            this.htBox2.Size = new System.Drawing.Size(100, 21);
            this.htBox2.TabIndex = 4;
            // 
            // stBox2
            // 
            this.stBox2.Location = new System.Drawing.Point(10, 32);
            this.stBox2.Name = "stBox2";
            this.stBox2.Size = new System.Drawing.Size(100, 21);
            this.stBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DegreeSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DegreeSwitch";
            this.Text = "DegreeSwitch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHtoS;
        private System.Windows.Forms.TextBox stBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox htBox1;
        private System.Windows.Forms.Button btnStoH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox htBox2;
        private System.Windows.Forms.TextBox stBox2;
        private System.Windows.Forms.Timer timer1;

    }
}