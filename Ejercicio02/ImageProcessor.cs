using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class ImageProcessor
    {
        public Bitmap ConvertToGrayScale(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            Parallel.For(0, image.Width, x =>
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    int average = (color.R + color.G + color.B) / 3;
                    Color grayColor = Color.FromArgb(average, average, average);
                    grayScale.SetPixel(x, y, grayColor);
                }
            });

            return grayScale;
        }
        }
}
