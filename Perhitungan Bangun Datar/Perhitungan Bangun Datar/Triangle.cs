using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Triangle : Shape
    {
        double width, height, diagonal;

        public Triangle(double aWidth, double aHeight, double aDiagonal)
        {
            width = aWidth;
            height = aHeight;
            diagonal = aDiagonal;
        }

        public override double area()
        {
            return width * height / 2;
        }

        public override double perimeter()
        {
            return width + height + diagonal;
        }
    }
}
