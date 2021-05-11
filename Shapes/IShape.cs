using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class AreaComparer : IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            if (x.getArea() > y.getArea())
                return 1;
            else if (x.getArea() < y.getArea())
                return -1;
            else return 0;
        }
        public void GetMaxArea(IShape[] shapes)
        {
            Array.Sort(shapes, new AreaComparer());
        }
    }

    public interface IShape
    {
        double getWidth();
        double getHeight();
        double getArea();
        double getPerimeter();
    }
}
