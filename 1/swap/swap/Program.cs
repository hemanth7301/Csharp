using System;

namespace swap
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("program from swap");
            int a, b;
            Console.WriteLine("Enter the 1st number");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter the 2nd number");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("before swap a={0} b={1}",a,b);
            swap(ref a,ref b);
            Console.WriteLine("after swap a={0} b={1}", a, b);
        }
    }
}
