using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingPanel
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p, p_white;
        Point p1, p2,po;
        bool IsDraw = false;// 是否取点

        int nowX, nowY, newX, newY,fixedX,fixedY;//鼠标位置x，y

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            p = new Pen(Color.Blue, 1);
            p_white = new Pen(Color.White, 1);
            //panel1.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDraw = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsDraw = true;

            p1 = new Point(e.X, e.Y);
            po = p1; //po 获取上次mousemove后的新点p2

            nowX = e.X;
            nowY = e.Y;

            //基点
            fixedX = e.X;
            fixedY = e.Y;
         
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Control ct in groupBox1.Controls)
            {
                RadioButton rb = ct as RadioButton;
                if (rb.Checked && rb.Text == "直线")
                {
                    if (IsDraw == true)
                    {
                        p2 = new Point(e.X, e.Y);
                        
                        g.DrawLine(p_white, p1, po);//白线重画——清除
                        g.DrawLine(p, p1, p2);
                        po = p2;
                        
                    }
                }
                else if (rb.Checked && rb.Text == "矩形")
                {
                    if (IsDraw == true)
                    {
                       
                        newX = e.X;//当前点
                        newY = e.Y;
                        g.DrawRectangle(p_white, nowX, nowY, nowX-fixedX, nowY-fixedY);
                        g.DrawRectangle(p, newX,newY, newX-fixedX, newY-fixedY);
                        
                        //上一个点
                        nowX = newX;
                        nowY = newY;

                    }
                }
                else if (rb.Checked && rb.Text == "自由画")
                {
                    if (IsDraw == true)
                    {
                        p2 = new Point(e.X, e.Y);
                        g.DrawLine(p, p1, p2);
                        p1 = p2;
                    }
                }
                else if (rb.Checked && rb.Text == "椭圆")
                {
                    if (IsDraw == true)
                    {
                        p2 = new Point(e.X, e.Y);
                        g.DrawEllipse(p, 80, 30, 100, 60);

                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
        }  
    }
}

