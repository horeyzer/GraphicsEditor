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
        enum Tools { None, Line, Circle };
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
                    case Tools.Line:MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, Color.Black);
                        break;
                    case Tools.Circle:float r = (float) Math.Sqrt((e.X - x0) * (e.X - x0) + (e.Y - y0) * (e.Y - y0));
                        MyGraphics.myCircle(x0, y0, r, bitmap, pictureBox1, Color.Black);
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
                        float r = (float)Math.Sqrt((e.X - x0) * (e.X - x0) + (e.Y - y0) * (e.Y - y0));
                        MyGraphics.myCircle(x0, y0, r, bitmap, pictureBox1, Color.Black);
                        break;
                }
                bitmap = bitmapClone;
            }
        }
    }
}