using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select one action");
            Console.WriteLine("Type 1 for Addition");
            Console.WriteLine("Type 2 for Subtraction");
            Console.WriteLine("Type 3 for Multiplication");
            Console.WriteLine("Type 4 for Division \n");
            int type,result=0;
            bool success =int.TryParse(Console.ReadLine(),out type);
            if (success == true)
            {
                Console.WriteLine("Enter 1st input");
                int a, b;
                int.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("Enter 2nd input");
                int.TryParse(Console.ReadLine(), out b);

                switch (type)
                {
                    case 1:
                        {
                            result = a + b;
                            break;
                        }
                    case 2:
                        {
                            result = a - b;
                            break;
                        }
                    case 3:
                        {
                            result = a*b;
                            break;
                        }
                    case 4:
                        {
                            result =a/b;
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }
                Console.WriteLine("The result is {0}", result);
            }
            else {
                Console.WriteLine("Run the program again and Enter valid type");
            }
        }
    }
}
