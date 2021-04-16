using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Square : Shape
    {
        double width;

        public Square(double aWidth)
        {
            width = aWidth;
        }

        public override double area()
        {
            return Math.Pow(width, 2);
        }

        public override double perimeter()
        {
            return 4 * width;
        }
    }
}
