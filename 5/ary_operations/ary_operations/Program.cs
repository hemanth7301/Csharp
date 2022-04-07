using System;

namespace ary_operations
{
    class Program
    {
        static void print(int[] temp) {
            foreach (int i in temp)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size;
            int.TryParse(Console.ReadLine(),out size);

            int[] arr = new int[size];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < size; i++) {
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            Console.WriteLine("original array: ");
            print(arr);

            
            int[] temp_arr=new int[size];

            Array.Copy(arr,temp_arr,size);
            Console.WriteLine("Copied array: ");
            print(temp_arr);

            Array.Sort(temp_arr);
            Console.WriteLine("Sorted array: ");
            print(temp_arr);

            Array.Reverse(temp_arr);
            Console.WriteLine("Reversed array: ");
            print(temp_arr);

            Array.Clear(temp_arr,0,size);
            Console.WriteLine("Cleared array: ");
            print(temp_arr);
        }
    }
}
