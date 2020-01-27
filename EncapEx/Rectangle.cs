using System;
using System.Collections.Generic;
using System.Text;

namespace EncapEx
{
    class Rectangle
    {
        private double l;
        private double w;

        public Rectangle()
        {
            SetLength(1);
            SetWidth(1);
        }
        public Rectangle(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        }

        public double Perimeter()
        {
            return 2 * (l + w);
        }
        public double Area()
        {
            return l * w;
        }
        private void SetLength(double length)
        {
            l = length;
        }

        private void SetWidth(double width)
        {
            w = width;
        }
    }
}
