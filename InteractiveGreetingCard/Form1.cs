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
using System.Media;

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

            label1.Visible = true;
            label1.Text = "ORION THE HUNTER";
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Viner Hand ITC", 27, FontStyle.Bold);
            label2.Visible = false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.BakerStreet);
            player.Play();

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

            Thread.Sleep(5000);

            Next.Visible = false;
            label1.Visible = false;
            this.Refresh();
            //clear page

            Thread.Sleep(1000);
            
            label1.Text = "Orion Mythology";
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Viner Hand ITC", 27, FontStyle.Bold);
            label2.Visible = true;
            label2.Text = "";
            label2.ForeColor = Color.White;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Comic Sans MS", 16, FontStyle.Regular);
            
            label1.Visible = true;
            this.Refresh();

            label2.Text = "I";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In G";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Gr";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Gre";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Gree";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek m";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek my";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek myt";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek myth";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mytho";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythol";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mytholo";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mytholog";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology,";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, O";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Or";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Ori";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orio";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion w";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion wa";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a g";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a gi";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a gia";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a gian";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant h";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant hu";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant hun";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant hunt";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant hunts";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsm";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsma";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "w";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "wh";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "who";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "whom";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "whom Z";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "whom Ze";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "whom Zeu";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
                "whom Zeus";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus p";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus pl";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus pla";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus plac";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus place";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed a";
            Thread.Sleep(100);
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed am";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed amo";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed amon";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among t";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among th";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the s";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the st";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the sta";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the star";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars a";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as t";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as th";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the c";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the co";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the con";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the cons";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the const";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the conste";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constel";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constell";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constella";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellat";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellati";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellatio";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation o";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of O";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of Or";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of Ori";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of Orio";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of Orion";
            Thread.Sleep(100);
            this.Refresh();
            label2.Text = "In Greek mythology, Orion was a giant huntsman " +
            "whom Zeus placed among the stars as the constellation of Orion.";
            Thread.Sleep(100);
            this.Refresh();
            //appearing text
        }
    }
}
