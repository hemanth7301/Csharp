using System;
using LitwareLib;
namespace management
{
        class Program
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee();
                e1.EmpNo = 1;
                e1.EmpName = "Hemanth";
                e1.Sal = 20000;

                Employee e2 = new Employee();
                e2.EmpNo = 2;
                e2.EmpName = "hello";
                e2.Sal = 5000;

                Console.WriteLine(" emp Id {0} Employee Name {1} Gross Salary {2} Net Salary {3}", e1.EmpNo, e1.EmpName, e1.Sal,e1.CalculateSalary());
                Console.WriteLine(" emp Id {0} Employee Name {1} Gross Salary {2} Net Salary {3}", e2.EmpNo, e2.EmpName, e2.Sal,e2.CalculateSalary());
            }
        }
}
