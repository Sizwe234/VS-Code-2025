using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library
{
    public class GeometryHelper
    {
        public static double CircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius Cannot Be negative");
            }
            return Math.PI * radius * radius;
        }

        public static double RectangleArea(double length, double width)
        {
            if (length < 0 | width < 0) {
                throw new ArgumentException("Dimensions cannot be Negative");
            }
            return length * width;
        }
    }
}
