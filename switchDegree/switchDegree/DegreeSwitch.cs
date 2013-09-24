using System;
using System.Windows.Forms;
using ClassTemperature;

namespace ClassTemperature
{
    public partial class DegreeSwitch : Form
    {
        ClassTemp dg = new ClassTemp();//dg类
        private Timer Timer;

        public DegreeSwitch()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString();
        }

        //华氏转摄氏温度
        private void btnHtoS_Click(object sender, EventArgs e)
        {
            string hdgree = htBox1.Text.Trim();//去掉空格
            dg.SourceTemp = float.Parse(hdgree);

            float result = dg.DegreeH2S();//转换结果
            stBox1.Text = result.ToString();
        }
        //摄氏转华氏温度
        private void btnStoH_Click(object sender, EventArgs e)
        {
            string sdegree = stBox2.Text.Trim();
            dg.SourceTemp = float.Parse(sdegree);//string 转 float
            float result = dg.DegreeS2H();//保存转换结果
            htBox2.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text ="当前时间为;"+ DateTime.Now.ToString();
        }
        //时间显示
        private void DegreeSwitch_Load(object sender, EventArgs e)
        {
            Timer = new Timer();
            Timer.Interval = 1000;//时间1000ms
            Timer.Tick += new EventHandler(timer1_Tick);
            Timer.Start();
        }
    }   
}
