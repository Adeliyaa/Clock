using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphingLab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.BlueViolet);
            SolidBrush br = new SolidBrush(Color.Blue);
            g.FillRectangle(br, 10, 10, 700, 400);
            Color col = Color.FromName("white");
            br = new SolidBrush(col);
            g.FillEllipse(br, 30, 40, 20, 20);
            g.FillEllipse(br, 300, 50, 20, 20);
            g.FillEllipse(br, 40, 350, 20, 20);
            g.FillEllipse(br, 30, 40, 20, 20);
            g.FillEllipse(br, 500, 40, 20, 20);
            g.FillEllipse(br, 300, 250, 20, 20);
            g.FillEllipse(br, 650, 220, 20, 20);
            g.FillEllipse(br, 600, 380, 20, 20);

            //6 angle polygon
            br = new SolidBrush(Color.Yellow);

            Point[] pts = new Point[]
            {
                new Point(315, 180),
                new Point(350, 160),
                new Point(385, 180),
                new Point(385, 200),
                new Point(350, 220),
                new Point(315, 200),
            };

            g.FillPolygon(br, pts);

            //Star1
            br = new SolidBrush(Color.Red);

            Point[] ptss1 = new Point[]
            {
                new Point(70, 70),
                new Point(60, 85),
                new Point(80, 85)
            };

            g.FillPolygon(br, ptss1);


            br = new SolidBrush(Color.Red);

            Point[] ptss2 = new Point[]
            {
                new Point(60, 75),
                new Point(80, 75),
                new Point(70, 90)
            };

            g.FillPolygon(br, ptss2);

            //Star2
            br = new SolidBrush(Color.Red);

            Point[] ptss3 = new Point[]
            {
                new Point(200, 320),
                new Point(180, 350),
                new Point(220, 350)
            };

            g.FillPolygon(br, ptss3);


            br = new SolidBrush(Color.Red);

            Point[] ptss4 = new Point[]
            {
                new Point(180, 330),
                new Point(220, 330),
                new Point(200, 360)
            };

            g.FillPolygon(br, ptss4);

            //Star3
            br = new SolidBrush(Color.Red);

            Point[] ptss5 = new Point[]
            {
                new Point(600, 150),
                new Point(580, 180),
                new Point(620, 180)
            };

            g.FillPolygon(br, ptss5);

            br = new SolidBrush(Color.Red);

            Point[] ptss6 = new Point[]
            {
                new Point(580, 160),
                new Point(620, 160),
                new Point(600, 190)
            };

            g.FillPolygon(br, ptss6);

            //Star4
            br = new SolidBrush(Color.Red);

            Point[] ptss7 = new Point[]
            {
                new Point(470, 230),
                new Point(455, 255),
                new Point(485, 255)
            };

            g.FillPolygon(br, ptss7);

            br = new SolidBrush(Color.Red);

            Point[] ptss8 = new Point[]
            {
                new Point(455, 240),
                new Point(485, 240),
                new Point(470, 265)
            };

            g.FillPolygon(br, ptss8);

            //Arrow
            br = new SolidBrush(Color.Green);

            Point[] ptss9 = new Point[]
            {
                new Point(350, 180),
                new Point(340, 190),
                new Point(360, 190)
            };

            g.FillPolygon(br, ptss9);

            br = new SolidBrush(Color.Green);

            Point[] ptss10 = new Point[]
            {
                new Point(345, 190),
                new Point(355, 190),
                new Point(355, 205),
                new Point(345, 205)
            };

            g.FillPolygon(br, ptss10);


            //STARRR
            br = new SolidBrush(Color.Green);

            Point[] ptss11 = new Point[]
            {
                new Point(380, 140),
                new Point(385, 150),
                new Point(395, 155),
                new Point(385, 160),
                new Point(380, 170),
                new Point(375, 160),
                new Point(365, 155),
                new Point(375, 150)
            };

            g.FillPolygon(br, ptss11);

        }
    }
}
