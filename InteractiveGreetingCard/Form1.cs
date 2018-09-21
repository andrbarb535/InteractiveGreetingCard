using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/// <summary>
/// Created By: Andrew Barber
/// Date: 2018-09-20
/// Description: Interactive Constillation Brochure
/// </summary>

namespace InteractiveGreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush drawBrush2 = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Imprint MT Shadow", 42, FontStyle.Bold);
            SolidBrush drawBrush3 = new SolidBrush(Color.Yellow);
            Random randGen = new Random();

            int h = 10;
            int w = 10;

            for (int i = 0; i <= 100; i++)
            {
                int rx, ry;

                rx = randGen.Next(1, this.Width);
                ry = randGen.Next(1, this.Height);

                g.FillEllipse(drawBrush, rx, ry, h, w);
            }

            g.FillEllipse(drawBrush, 150, 550, 10, 10);
            //orion right foot

            g.FillEllipse(drawBrush, 300, 520, 10, 10);
            //orion left foot
            
            g.FillEllipse(drawBrush, 200, 400, 10, 10);
            g.FillEllipse(drawBrush, 220, 390, 10, 10);
            g.FillEllipse(drawBrush, 240, 375, 10, 10);
            //orion belt
            
            g.FillEllipse(drawBrush, 125, 195, 10, 10);
            g.FillEllipse(drawBrush, 230, 150, 10, 10);
            g.FillEllipse(drawBrush, 275, 200, 10, 10);
            //orion torso
            
            g.FillEllipse(drawBrush, 75, 145, 10, 10);
            g.FillEllipse(drawBrush, 20, 10, 10, 10);
            //orion left arm
            
            g.FillEllipse(drawBrush, 475, 10, 10, 10);
            g.FillEllipse(drawBrush, 540, 50, 10, 10);
            g.FillEllipse(drawBrush, 570, 250, 10, 10);
            g.FillEllipse(drawBrush, 525, 325, 10, 10);
            //orion bow

            for (float x = 600; x >= 450; x = x - 2)
            {
                g.DrawEllipse(drawPen, x, 190, 10, 10);
                g.FillEllipse(drawBrush, x, 190, 10, 10);
                //orion bowstring

                Thread.Sleep(100);
            }
            
            //this.Refresh();
            
            Pen drawPen2 = new Pen(Color.Green, 1);

            g.DrawLine(drawPen2, 150, 550, 300, 520);
            g.DrawLine(drawPen2, 150, 550, 200, 400);
            g.DrawLine(drawPen2, 200, 400, 220, 390);
            g.DrawLine(drawPen2, 220, 390, 240, 377);
            g.DrawLine(drawPen2, 240, 377, 300, 520);
            //constelation lower body

            g.DrawLine(drawPen2, 240, 377, 275, 200);
            g.DrawLine(drawPen2, 275, 200, 230, 150);
            g.DrawLine(drawPen2, 230, 150, 125, 195);
            g.DrawLine(drawPen2, 125, 195, 200, 400);
            //constelation upper body

            g.DrawLine(drawPen2, 125, 195, 75, 145);
            g.DrawLine(drawPen2, 75, 145, 20, 10);
            //constelation left arm

            g.DrawLine(drawPen2, 475, 10, 540, 50);
            g.DrawLine(drawPen2, 540, 50, 450, 190);
            g.DrawLine(drawPen2, 450, 190, 570, 250);
            g.DrawLine(drawPen2, 570, 250, 525, 325);
            //constelation bow

            g.DrawLine(drawPen2, 450, 190, 275, 200);
            //constelation left arm

            Next.Visible = false;
        }
    }
}
