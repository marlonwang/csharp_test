using System;
using System.Windows.Forms;

namespace ClassTemperature
{
    public partial class DegreeSwitch : Form
    {
        ClassTemp dg;//dg类

        public DegreeSwitch()
        {
            InitializeComponent();
        }
       // Degree dg = new Degree();

        private void btnHtoS_Click(object sender, EventArgs e)
        {
            string hdgree = htBox1.Text.Trim();//去掉空格
            dg.SourceTemp = float.Parse(hdgree);
            
            float result = dg.DegreeH2S();
            stBox1.Text = result.ToString();
        }

        private void btnStoH_Click(object sender, EventArgs e)
        {
            string sdegree = stBox2.Text.Trim();
            dg.SourceTemp = float.Parse(sdegree);
            float result = dg.DegreeS2H();
            htBox2.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            label1.Text = dt.ToString();
        }
    }
}
