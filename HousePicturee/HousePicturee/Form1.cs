using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousePicturee
{
    
    public partial class Form1 : Form
    {
        int time = 0;
        int time2 = 0;
        int time3 = 0;
        //int count = 0;
        int r1 = -60, r2 = -30;
        int stepX = -60, stepY = 60;
        int step1X = -80, step1Y = 80;
        int r3 = -80, r4 = -40;
        int step2X = -100, step2Y = 100;
        int r5 = -100, r6 = -50;

        private void Timer2_Tick(object sender, EventArgs e)
        {
            
        }

        
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            time2 += 1;
            time3 += 1;
            stepX += 4;
            stepY -= 4;
            
            r1 += 4;
            r2 += 2;

            step1X += 4;
            step1Y -= 4;

            r3 += 4;
            r4 += 2;

            step2X += 4;
            step2Y -= 4;

            r5 += 4;
            r6 += 2;

            if(time == 25)
            {
              time = 15;
              stepX = 0;
              stepY = 0;
              r1 = 0;
              r2 = 0;
            }

            if (time2 == 30)
            {
                time2 = 20;
                step1X = 0;
                step1Y = 0;
                r3 = 0;
                r4 = 0;
            }

            if (time3 == 35)
            {
                time3 = 25;
                step2X = 0;
                step2Y = 0;
                r5 = 0;
                r6 = 0;
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red);
            SolidBrush br = new SolidBrush(Color.Red);

            if (time > 1)
            {
                g.DrawLine(p, 300, 200, 350, 100);
            }

            if (time > 2)
            {
                g.DrawLine(p, 350, 100, 400, 200);
            }

            if (time > 3)
            {
                g.DrawLine(p, 350, 100, 400, 200);
            }

            if (time > 4)
            {
                g.DrawLine(p, 300, 200, 400, 200);
            }

            if (time >= 6)
            {
                Point[] pts = new Point[]
            {
                new Point(300, 200),
                new Point(350, 100),
                new Point(400, 200)
            };
                g.FillPolygon(br, pts);
            }

            p = new Pen(Color.Brown);
            br = new SolidBrush(Color.DarkOrange);
            if (time > 7)
            {
                g.DrawLine(p, 300, 200, 300, 300);
            }

            if (time > 8)
            {
                g.DrawLine(p, 300, 300, 400, 300);
            }

            if (time > 10)
            {
                g.DrawLine(p, 400, 300, 400, 200);
            }

            if (time >= 11)
            {
                Point[] pts1 = new Point[]
               {
                new Point(300, 200),
                new Point(300, 300),
                new Point(400, 300),
                new Point(400, 200)
               };
                g.FillPolygon(br, pts1);
            }

            p = new Pen(Color.Black);
            if (time > 12)
            {
                g.DrawLine(p, 365, 130, 365, 100);
            }

            if (time > 13)
            {
                g.DrawLine(p, 373, 143, 373, 100);
            }

            if (time == 14)
            {
                g.DrawEllipse(p, 365, 90, 10, 10);
            }

            if (time >= 15  && time <= 25 )
            {
                g.DrawEllipse(p, 365 + stepX, 90 + stepY, 10 + r1, 10 + r2);
            }
         

            if (time2 >= 20 && time2 <= 30)
            {
                g.DrawEllipse(p, 365 + step1X, 90 + step1Y, 10 + r3, 10 + r4);
            }
            
            if (time3 >= 25 && time3 <= 35)
            {
                g.DrawEllipse(p, 365 + step2X, 90 + step2Y, 10 + r5, 10 + r6);
            }


            // g.DrawLine(p, 300, 200, 300, 300);
        }

        
    }
}
