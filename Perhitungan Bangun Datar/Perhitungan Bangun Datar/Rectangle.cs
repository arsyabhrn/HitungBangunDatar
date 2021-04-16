using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Rectangle
    {
        double width, height;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Area()
        {
            return height * width;
        }

        public double Perimeter()
        {
            return 2 * (height + width);
        }
    }
}
