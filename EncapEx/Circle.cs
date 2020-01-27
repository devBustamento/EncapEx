using System;
using System.Collections.Generic;
using System.Text;

namespace EncapEx
{
    public class Circle
    {
        private double pi = 3.14;
        private double r;

        public Circle()
        {
            r = 1;
        }

        public Circle(double radius)
        {
            SetRadius(radius);
        }
        public double Circum()
        {
            return 2 * pi * r;
        }

        public double Area()
        {
            return pi * r * r;
        }

        private void SetRadius(double radius)
        {
            r = radius;
        }
    }
}
