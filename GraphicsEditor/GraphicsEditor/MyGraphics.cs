using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{
    internal class MyGraphics
    {
        public static void myLine(int x0, int y0, int x1, int y1, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            // DDA algorithm
            int dl; //no of iteration
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;

            //horizontal line
            if(y1 == y0)
            {
                int dxii;
                int xii = x0;
                dl = Math.Abs(x1 - x0);
                if (x0 < x1) dxii = 1; else dxii = -1;
                for(int i = 0; i <= dl; i++)
                {
                    if((xii > 1)&&(xii < width)&&(y0 > 1)&&(y0 < height))
                    bitmap.SetPixel(xii, y0, color);
                    xii += dxii;
                }
                pictureBox.Image = bitmap;
                return;
            }

            // vertical line
            if(x1 == x0)
            {
                int dyii;
                int yii = y0;
                dl = Math.Abs(y1 - y0);
                if(y0 < y1) dyii = 1; else dyii = -1;
                for(int i = 0; i <= dl; i++)
                {
                    if((x0 > 1)&&(x0 < width)&&(yii > 1)&&(yii < height))
                    bitmap.SetPixel(x0, yii, color);
                    yii += dyii;
                }
                pictureBox.Image = bitmap;
                return;
            }

            //slope line
            float xi = x0, yi = y0;
            float m = (float) (y1 - y0) / (x1 - x0);
            float dx, dy;
            if(Math.Abs(x1 - x0) > Math.Abs(y1 - y0))
            {
                dl = Math.Abs(x1 - x0);
                if(x0 < x1) dx = 1; else dx = -1;
                dy = m * dx;
            }
            else
            {
                dl = Math.Abs(y1 - y0);
                if(y0 < y1) dy = 1; else dy = -1;
                dx = dy / m;
            }
            for(int i = 0; i <= dl; i++)
            {
                if((xi > 1)&&(xi < width)&&(yi > 1)&&(yi < height))
                bitmap.SetPixel((int)xi, (int)yi, color);
                xi += dx; yi += dy;
            }
            pictureBox.Image = bitmap;
        } // end of myLine

        public static void myCircle(int x0, int y0, float r, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;
            int itteration;
            float coefficent;
            int xi, yi;
            if (r <= 50) { itteration = 360; coefficent = 1; }
            else if ( r <= 100) { itteration = 720; coefficent = 0.5f; }
            else { itteration = 1440; coefficent = 0.25f; }
            for(int i = 0; i <= itteration; i++)
            {
                xi = (int)(x0 + r * Math.Cos(i * coefficent * Math.PI / 180));
                yi = (int)(y0 + r * Math.Sin(i * coefficent * Math.PI / 180));
                if((xi > 1)&&(xi < width)&&(yi > 1)&&(yi < height))
                bitmap.SetPixel(xi, yi, color);
            }
            pictureBox.Image = bitmap;
        } // end of myCircle

        public static void myEllipse(int x0, int y0, int a, int b, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;
            int iteration;
            float coefficient;
            int xi, yi;
            int max = Math.Max(a, b);
            if (max <= 50) { iteration = 360; coefficient = 1; }
            else if (max <= 100) { iteration = 720; coefficient = 0.5f; }
            else { iteration = 1440; coefficient = 0.25f; }
            for (int i = 0; i <= iteration; i++)
            {
                xi = (int)(x0 + a * Math.Cos(i * coefficient * Math.PI / 180));
                yi = (int)(y0 + b * Math.Sin(i * coefficient * Math.PI / 180));
                if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                    bitmap.SetPixel(xi, yi, color);
            }
            pictureBox.Image = bitmap;
        }

        public static void myFloodFill(int x, int y, Bitmap bitmap, Color fillColor, Color innerColor)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            if (innerColor == fillColor)
                return;

            bool[,] visited = new bool[width, height]; // Track visited pixels

            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((x, y));

            while (stack.Count > 0)
            {
                (int currentX, int currentY) = stack.Pop();

                if (currentX < 0 || currentX >= width || currentY < 0 || currentY >= height || visited[currentX, currentY])
                    continue;

                visited[currentX, currentY] = true;

                if (bitmap.GetPixel(currentX, currentY) != innerColor)
                    continue;

                bitmap.SetPixel(currentX, currentY, fillColor);

                stack.Push((currentX + 1, currentY));
                stack.Push((currentX - 1, currentY));
                stack.Push((currentX, currentY + 1));
                stack.Push((currentX, currentY - 1));
            }
        }
    }
}
