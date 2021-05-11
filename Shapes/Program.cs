using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Square square1 = new Square(4);

            Console.WriteLine("Площадь фигуры равна " + square1.getArea());

            Circle circle1 = new Circle(5);

            Console.WriteLine("Площадь фигуры равна " + circle1.getArea());
            */
            IShape[] shapes = { new Square(3), new Square(2), new Square(4), new Circle(3), new Circle(4), new Circle(2) };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].getArea());
            }

            Console.WriteLine();

            Array.Sort(shapes, new AreaComparer());

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].getArea());
            }

            Console.ReadKey();
        }
    }
}
