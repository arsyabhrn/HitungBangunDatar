using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Parallelogram : Shape
    {
        double width, height, diagonal;

        public Parallelogram(double aWidth, double aHeight, double aDiagonal)
        {
            width = aWidth;
            height = aHeight;
            diagonal = aDiagonal;
        }

        public override double area()
        {
            return width * height;
        }

        public override double perimeter()
        {
            return 2 * (width + diagonal);
        }
    }
}
