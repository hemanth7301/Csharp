using System;
using employee;
using System.Collections.Generic;
namespace delegates
{
    class Program
    {
        public delegate void printing(List<Employee> empList);
        public delegate void printing_next(List<Employee> empList);
        static void Main(string[] args)
        {
            Program p = new Program();
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "Hemanth";
            e1.Salary = 20000;

            Employee e2 = new Employee();
            e2.ID = 2;
            e2.Name = "Mohan";
            e2.Salary = 25000;

            Employee e3 = new Employee();
            e3.ID = 3;
            e3.Name = "BALA";
            e3.Salary = 20000;

            Manager e4 = new Manager();
            e4.ID = 4;
            e4.Name = "Phani";
            e4.Salary = 23000;


            MarketingExecutive e5 = new MarketingExecutive();
            e5.ID = 5;
            e5.Name = "Gowthami";
            e5.Salary = 20000;
            e5.KM = 25;

            List<Employee> emplist = new List<Employee>();
            emplist.Add(e1);
            emplist.Add(e2);
            emplist.Add(e3);
            emplist.Add(e4);
            emplist.Add(e5);


            printing print1 = new printing(status1);

            print1(emplist);//unicast delegate prints all employees including manager and MarketingExecutive

            printing_next pro = new printing_next(status2);
            //pro(emplist) unicast delegate prints all managers
            pro += status3;
            pro(emplist);// prints managers and marketing executive
        }
        public static bool manager(Employee emp)
        {
            if (emp.GetType().Name=="Manager")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void status1(List<Employee> empList) {
            Console.WriteLine("Employee list");
            foreach (Employee e in empList) {
                Console.WriteLine("{0} {1} {2} ", e.ID, e.Name, e.Salary);
                }
            Console.WriteLine();
        }
        public static void status2(List<Employee> empList)
        {
            Console.WriteLine("Manager list");
            foreach (Employee e in empList)
            {
                if((e.GetType().Name)=="Manager") {
                    Console.WriteLine("{0} {1} {2}", e.ID, e.Name, e.Salary);
                }
                
            }
            Console.WriteLine();
        }
        public static void status3(List<Employee> empList)
        {
            Console.WriteLine("MarketingExecutive list");
            foreach (Employee e in empList)
            {
                if ((e.GetType().Name) == "MarketingExecutive")
                {
                    Console.WriteLine("{0} {1} {2}", e.ID, e.Name, e.Salary);
                }

            }
            Console.WriteLine();
        }
    }
    }

