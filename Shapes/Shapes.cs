using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double getArea()
        {
            return side * side;
        }

        public double getHeight()
        {
            return side;
        }

        public double getPerimeter()
        {
            return side * 4;
        }

        public double getWidth()
        {
            return side;
        }
    }
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return 3.14 * radius * radius;
        }

        public double getHeight()
        {
            return radius * 2;
        }

        public double getPerimeter()
        {
            return 2 * 3.14 * radius;
        }

        public double getWidth()
        {
            return radius * 2;
        }
    }
}
