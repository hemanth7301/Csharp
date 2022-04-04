using System;

namespace sum
{
    class Program
    {
        public static void sumofarray(params int[] a) {
            int sum=0;
            foreach (int item in a) {
                sum += item;
            }
            Console.WriteLine("Sum of array elements is {0}", sum);
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 5 elements for array");
            int[] a = new int[5];
            for (int i = 0; i < 5; i++) {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            sumofarray(a);
        }
    }
}
