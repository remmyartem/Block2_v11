using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block2_v11
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen1;
        Pen pen2;
        Pen pen3;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pen1 = new Pen(Color.Black, 2);
            pen2 = new Pen(Color.Red, 2);
            pen3 = new Pen(Color.LightGray, 2);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = bitmap;
            g.Clear(Color.White);
            Rectangle display = new Rectangle(40,60,140,90);
            Rectangle frame = new Rectangle(35, 55, 150, 100);
            Rectangle p = new Rectangle(95, 150, 30, 40);
            Rectangle ellipse = new Rectangle(80,175,60,30);
            Rectangle keyboard = new Rectangle(40, 225, 140, 50);
            Rectangle keys1 = new Rectangle(45, 230, 100, 40);
            Rectangle keys2 = new Rectangle(150, 230, 25, 40);
            Rectangle cover = new Rectangle(200, 215, 70, 70);
            Rectangle mouse = new Rectangle(225, 230, 30, 40);
            Point[] l1 = new Point[] { new Point(225,245), new Point(255,245) };
            Point[] l2 = new Point[] { new Point(240, 230), new Point(240, 245) };
            Point[] corp1 = new Point[] { new Point(210, 60), new Point(230, 50), new Point(230, 200), new Point(210, 190),new Point(210, 60) };
            Point[] corp2 = new Point[] { new Point(230, 50), new Point(300, 50), new Point(300, 200), new Point(230, 200), new Point(230, 50) };
            Point[] disk1 = new Point[] { new Point(235, 60), new Point(295, 60), new Point(295, 75), new Point(235, 75), new Point(235, 60) };
            Point[] disk2 = new Point[] { new Point(235, 80), new Point(295, 80), new Point(295, 95), new Point(235, 95), new Point(235, 80) };
            Rectangle button = new Rectangle(240, 125, 20, 20);
            Rectangle light1 = new Rectangle(265, 62, 10, 10);
            Rectangle light2 = new Rectangle(280, 62, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Gray), ellipse);
            g.DrawEllipse(pen1, ellipse);
            g.FillRectangle(new SolidBrush(Color.Gray), p);
            g.DrawRectangle(pen1, p);
            g.FillRectangle(new SolidBrush(Color.Gray), frame);
            g.DrawRectangle(pen1, frame);
            g.FillRectangle(new SolidBrush(Color.Blue), display);
            g.DrawRectangle(pen1, display);
            g.FillRectangle(new SolidBrush(Color.Gray), keyboard);
            g.DrawRectangle(pen1, keyboard);
            g.FillRectangle(new SolidBrush(Color.LightGray), keys1);
            g.DrawRectangle(pen1, keys1);
            g.FillRectangle(new SolidBrush(Color.LightGray), keys2);
            g.DrawRectangle(pen1, keys2);
            g.FillRectangle(new SolidBrush(Color.Black), cover);
            g.DrawRectangle(pen2, cover);
            g.FillEllipse(new SolidBrush(Color.Gray), mouse);
            g.DrawLines(pen3, l1);
            g.DrawLines(pen3, l2);
            g.FillPolygon(new SolidBrush(Color.Gray), corp1);
            g.DrawLines(pen1, corp1);
            g.FillPolygon(new SolidBrush(Color.Gray), corp2);
            g.DrawLines(pen1, corp2);
            g.FillPolygon(new SolidBrush(Color.LightGray), disk1);
            g.DrawLines(pen1, disk1);
            g.FillPolygon(new SolidBrush(Color.LightGray), disk2);
            g.DrawLines(pen1, disk2);
            g.FillEllipse(new SolidBrush(Color.LightGray), button);
            g.DrawEllipse(pen2, button);
            g.FillEllipse(new SolidBrush(Color.Green), light1);
            g.FillEllipse(new SolidBrush(Color.Red), light2);
        }
    }
}
