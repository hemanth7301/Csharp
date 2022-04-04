using System;

namespace swap
{
    class Program
    {
        static void circle(int r)
        {
            double area, circumfernce;
            area = 3.14 * r * r;
            circumfernce = 2 * 3.14 * r;
            Console.WriteLine("Area={0} Circumference={1}", area, circumfernce);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("program from area and circumference");
            int r;
            Console.WriteLine("Enter radius");
            int.TryParse(Console.ReadLine(), out r);
            circle(r);
        }
    }
}
