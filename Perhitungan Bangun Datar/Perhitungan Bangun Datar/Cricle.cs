using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Circle : Shape
    {
        double radius;

        public Circle(double aRadius)
        {
            radius = aRadius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
