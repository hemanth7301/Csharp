using System;

namespace avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e,f;
            Console.WriteLine("Enter 1st student marks");
            int.TryParse(Console.ReadLine(), out a);
            f = a;
            Console.WriteLine("Enter 2nd student marks");
            int.TryParse(Console.ReadLine(), out b);
            if (b > f){
                f = b;
            }
            Console.WriteLine("Enter 3rd student marks");
            int.TryParse(Console.ReadLine(), out c);
            if (c > f)
            {
                f = c;
            }
            Console.WriteLine("Enter 4th student marks");
            int.TryParse(Console.ReadLine(), out d);
            if (d > f)
            {
                f = d;
            }
            Console.WriteLine("Enter 5th student marks");
            int.TryParse(Console.ReadLine(), out e);
            if (e > f)
            {
                f = e;
            }
            Console.WriteLine("AVG is {0}",(a+b+c+d+e)/5);
            Console.WriteLine("MAX is {0}", f);

        }
    }
}
