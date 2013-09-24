using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Temperature;

namespace TemControl
{
    public partial class UserControl1 : UserControl
    {
        ClassTemp dg=new ClassTemp();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hdgree = textBox1.Text.Trim();//去掉空格
            dg.SourceTemp = float.Parse(hdgree);

            float result = dg.DegreeH2S();//转换结果
            textBox2.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sdegree = textBox3.Text.Trim();
            dg.SourceTemp = float.Parse(sdegree);//string 转 float
            float result = dg.DegreeS2H();//保存转换结果
            textBox4.Text = result.ToString();
        }
    }
}