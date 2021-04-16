using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhitungan_Bangun_Datar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string repeat;
                do
                {
                    Console.WriteLine("Input Number From 1-5" + Environment.NewLine +
                        "1. Square Area" + Environment.NewLine +
                        "2. Rectangle Area" + Environment.NewLine +
                        "3. Triangle Area" + Environment.NewLine +
                        "4. Circle Area" + Environment.NewLine +
                        "5. Parallelogram Area" + Environment.NewLine);

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            // code block
                            Console.WriteLine("Input Your Width (cm)");
                            double width = Convert.ToDouble(Console.ReadLine());                            
                            Shape square = new Square(width);
                            Console.WriteLine("Square Area is " + square.area());
                            break;
                        case 2:
                            // code block
                            Console.WriteLine("Input Your Width (cm)");
                            width = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input Your Height (cm)");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Rectangle rectangle = new Rectangle();
                            rectangle.Height = height;
                            rectangle.Width = width;
                            Console.WriteLine("Rectangle Area is " + rectangle.Area());
                            break;
                        case 3:
                            // code block
                            Console.WriteLine("Input Your Width (cm)");
                            width = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input Your Height (cm)");
                            height = Convert.ToDouble(Console.ReadLine());
                            Shape triangle = new Triangle(width, height);
                            Console.WriteLine("Triangle Area is " + triangle.area());
                            break;
                        case 4:
                            // code block
                            Console.WriteLine("Input Your Radius (cm)");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Shape circle = new Circle(radius);
                            Console.WriteLine("Circle Area is " + circle.area());
                            break;
                        case 5:
                            // code block
                            Console.WriteLine("Input Your Width (cm)");
                            width = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input Your Height (cm)");
                            height = Convert.ToDouble(Console.ReadLine());
                            Shape parallelogram = new Parallelogram(width, height);
                            Console.WriteLine("Parallelogram Area is " + parallelogram.area());
                            break;
                        default:
                            // code block
                            Console.WriteLine("masukkan angka dari 1-5");
                            break;
                    }
                    Console.WriteLine("ketik \"yes\" untuk mengulang program");
                    repeat = Console.ReadLine().ToLower();
                } while (repeat == "yes");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak bisa dibagi dengan angka 0");

            }
            catch (FormatException)
            {
                Console.WriteLine("Tolong masukkan dengan format yang benar");
            }
        }
    }
}
