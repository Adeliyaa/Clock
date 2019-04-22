using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        int t,k = 0;
        int a,b = 0;
        int c,d = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            
            if (k>0 && k<=15)
            g.DrawLine(p, 400, 240, 400+t, 180+t);
            if(k>=16 && k<=30)
            g.DrawLine(p, 400, 240, 460-t, 240+t);
            if(k>=31 && k<=45)
            g.DrawLine(p, 400, 240, 400-t, 300-t);
            if(k>=46 && k<=60)
            g.DrawLine(p, 400, 240, 340+t, 240-t);

            p = new Pen(Color.Yellow);
            if (a >= 0 && a <= 15)
                g.DrawLine(p, 400, 240, 400 + b, 180 + b);
            if (a >= 16 && a <= 30)
                g.DrawLine(p, 400, 240, 460 - b, 240 + b);
            if (a >= 31 && a <= 45)
                g.DrawLine(p, 400, 240, 400 - b, 300 - b);
            if (a >= 46 && a <= 60)
                g.DrawLine(p, 400, 240, 340 + b, 240 - b);

            //g.DrawEllipse(p, 420, 230, 50, 50);

            p = new Pen(Color.Blue);
            if (c >= 0 && c <= 15)
                g.DrawLine(p, 400, 240, 400 + d, 180 + d);
            if (c >= 16 && c <= 30)
                g.DrawLine(p, 400, 240, 460 - d, 240 + d);
            if (c >= 31 && c <= 45)
                g.DrawLine(p, 400, 240, 400 - d, 300 - d);
            if (c >= 46 && c <= 60)
                g.DrawLine(p, 400, 240, 340 + d, 240 - d);


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (k == 60)
            {
                t = 0;
                
                k = 0;
            }
            if (k == 15)
            {
                t = 0;
               
            }
            if (k == 30)
            {
                t = 0;
                
            }
            if (k == 45)
            {
                t = 0;
               
            }
            t += 4;
            k += 1;
            Refresh();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (c == 60)
            {
                d = 0;

                c = 0;
            }
            if (c == 15)
            {
                d = 0;

            }
            if (c == 30)
            {
                d = 0;

            }
            if (c == 45)
            {
                d = 0;

            }
            d += 4;
            c += 1;
            Refresh();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (a == 60)
            {
                b = 0;
               
                a = 0;
            }
            if (a == 15)
            {
                b = 0;
                
            }
            if (a == 30)
            {
                b = 0;
                
            }
            if (a == 45)
            {
                b = 0;
            }
            b += 4;
            a += 1;
            Refresh();
        }
    }
}
