using System;
using System.Collections.Generic;
using System.Text;

namespace EncapEx
{
    class Square
    {
        private double s;
        public Square()
        {
            SetSide(1);
        }
        public Square(double side)
        {
            SetSide(side);
        }

        public double Perimeter()
        {
            return 2 * s;
        }
        public double Area()
        {
            return s * s;
        }
        private void SetSide(double side)
        {
            s = side;
        }
    }
}
