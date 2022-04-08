using System;
using System.Collections;
using System.Reflection;
using bank;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var emplist=new ArrayList();
            emplist.Add(new employee() { ID = 101, Salary = 1000, Name = "hemanth" });
            emplist.Add(new employee() { ID = 102, Salary = 2000, Name = "Hello" });
            emplist.Add(new employee() { ID = 103, Salary = 3000, Name = "HI" });
            emplist.Add(new employee() { ID = 104, Salary = 4000, Name = "Bye" });
            emplist.Add(new employee() { ID = 105, Salary = 5000, Name = "ok" });

            foreach (employee e in emplist) {
                Console.WriteLine("ID {0},NAME {1},SALARY {2}",e.ID, e.Name, e.Salary);
            }

        }
    }
}
