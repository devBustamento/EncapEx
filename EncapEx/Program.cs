using System;

namespace EncapEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle one = new Circle(7);
            Console.WriteLine(one.Area());
            Console.WriteLine(one.Circum());

            Rectangle two = new Rectangle(14, 4);
            Console.WriteLine(two.Area());
            Console.WriteLine(two.Perimeter());

            Square three = new Square(6);
            Console.WriteLine(three.Area());
            Console.WriteLine(three.Perimeter());

        }

    }
}
