using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        Bitmap bitmap, bitmapClone;
        enum Tools { None, Line, Circle, Ellipse };
        Tools tool = Tools.None;
        int x0, y0;
        bool mouseDown = false;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tools.None;
        }

        private void btnLine_Click_Click(object sender, EventArgs e)
        {
            tool = Tools.Line;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            tool = Tools.Circle;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            tool = Tools.Ellipse;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tool != Tools.None)
            {
                x0 = e.X;
                y0 = e.Y;
                mouseDown = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((tool != Tools.None)&& mouseDown)
            {
                switch(tool)
                {
                    case Tools.Line:
                        MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, Color.Black);
                        break;
                    case Tools.Circle:
                        int xm = (x0 + e.X) / 2, ym = (y0 + e.Y) / 2;
                        float r = (float)Math.Sqrt((e.X - xm) * (e.X - xm) + (e.Y - ym) * (e.Y - ym));
                        MyGraphics.myCircle(xm, ym, r, bitmap, pictureBox1, Color.Black);
                        break;
                    case Tools.Ellipse:
                        int a = Math.Abs(e.X - x0), b = Math.Abs(e.Y - y0);
                        MyGraphics.myEllipse(x0, y0, a, b, bitmap, pictureBox1, Color.Black);
                        break;
                }
                mouseDown = false;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if((tool != Tools.None) && mouseDown)
            {
                bitmapClone = (Bitmap)bitmap.Clone();
                switch (tool)
                {
                    case Tools.Line:
                        MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, Color.Black);
                        break;
                    case Tools.Circle:
                        int xm=(x0+e.X)/2, ym=(y0+e.Y)/2;
                        float r = (float)Math.Sqrt((e.X - xm) * (e.X - xm) + (e.Y - ym) * (e.Y - ym));
                        MyGraphics.myCircle(xm, ym, r, bitmap, pictureBox1, Color.Black);
                        break;
                    case Tools.Ellipse:
                        int a = Math.Abs(e.X - x0), b = Math.Abs(e.Y - y0);
                        MyGraphics.myEllipse(x0, y0, a, b, bitmap, pictureBox1, Color.Black);
                        break;
                }
                bitmap = bitmapClone;
            }
        }
    }
}