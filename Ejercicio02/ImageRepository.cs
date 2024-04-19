using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class ImageRepository
    {
        public Bitmap LoadImage(string path)
        {
            return new Bitmap(path);
        }

        public Bitmap ProcessImage(Bitmap image)
        {
            ImageProcessor processor = new ImageProcessor();
            return processor.ConvertToGrayScale(image);
        }
    }
}
