using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Temperature;

namespace Switchdegree
{
    public partial class Form1 : Form
    {
        private Timer Timer;
        ClassTemp dg = new ClassTemp();//从内库中实例化

        public Form1()
        {
            InitializeComponent();
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "当前时间为;" + DateTime.Now.ToString();
        }

        //时间显示
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new Timer();
            Timer.Interval = 1000;//时间1000ms
            Timer.Tick += new EventHandler(timer1_Tick);
            Timer.Start();
        }
        //华氏转摄氏
        private void btnHtoS_Click(object sender, EventArgs e)
        {
            string hdgree = htBox1.Text.Trim();//去掉空格
            dg.SourceTemp = float.Parse(hdgree);

            float result = dg.DegreeH2S();//转换结果
            stBox1.Text = result.ToString();
        }
        //摄氏转华氏
        private void btnStoH_Click(object sender, EventArgs e)
        {
            string sdegree = stBox2.Text.Trim();
            dg.SourceTemp = float.Parse(sdegree);//string 转 float
            float result = dg.DegreeS2H();//保存转换结果
            htBox2.Text = result.ToString();
        }

       
    }
}