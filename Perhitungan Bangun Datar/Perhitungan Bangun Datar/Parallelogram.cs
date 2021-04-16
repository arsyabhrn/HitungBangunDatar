using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Parallelogram : Shape
    {
        double width, height;

        public Parallelogram(double aWidth, double aHeight)
        {
            width = aWidth;
            height = aHeight;
        }

        public override double area()
        {
            return width * height;
        }
    }
}
