using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Points
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Olustur();
        }

        private void Olustur()
        {
            Graphics g = pictureBox1.CreateGraphics();

            Point point = new Point(0, pictureBox1.Height / 2);
            Point point2 = new Point(pictureBox1.Width, pictureBox1.Height / 2);

            Point point3 = new Point(pictureBox1.Width / 2, 0);
            Point point4 = new Point(pictureBox1.Width / 2, pictureBox1.Height);

            g.DrawLine(Pens.Blue, point, point2);
            g.DrawLine(Pens.Blue, point3, point4);
        }

       

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            Graphics g = pictureBox1.CreateGraphics();

            g.Clear(Color.LightGray);

            Olustur();

            int x = 0;
            int y = 0;

            int originX = pictureBox1.Width / 2;
            int orihinY = pictureBox1.Height / 2;

            x = e.Location.X - originX;
            y = orihinY - e.Location.Y;
            
            Point point = new Point(x, y);
            
            label1.Text = "X: " + point.X + " Y: " + point.Y;

            x += pictureBox1.Width / 2;
            y = pictureBox1.Height / 2 - y;

            point.X = x;
            point.Y = y;
           
            Point pointY = new Point(pictureBox1.Width/2,point.Y);
            Point pointX = new Point(point.X,pictureBox1.Height/2);

            g.DrawLine(Pens.Red, point, pointX);
            g.DrawLine(Pens.Red,point, pointY);

        }
    }
}
