using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<string>();
            string c = "yes";
            while (c == "yes") {
                Console.WriteLine("Enter employee name ");
                employees.Add(Console.ReadLine());
                Console.WriteLine("Do you want to add more yes/no");
                c = Console.ReadLine();
            }
            Console.WriteLine("Employee List");
            foreach (string i in employees) {
                Console.WriteLine(i + " ");
            }
            

            Console.WriteLine("No of employees: " + employees.Count);

        }
    }
}
