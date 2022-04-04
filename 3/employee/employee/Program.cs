using System;

namespace employee
{
    interface IPrintable {
        void print();
    }
    class Employee : IPrintable
    {
        private int id;
        private double salary;
        private string name;
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
        public virtual double CalculateSalary() {
            return this.salary;
        }
        public virtual void print()
        {
            Console.WriteLine("ID of the {0} is {1}", this.GetType().Name,this.id);
            Console.WriteLine("Name of the {0} is {1}", this.GetType().Name, this.name);
            Console.WriteLine("Salary of the {0} is {1}", this.GetType().Name,this.CalculateSalary());
        }
        
    }
    class Manager : Employee
    {
        double PA, FA, OA;
        public override double CalculateSalary()
        {
            PA = 0.8 * this.Salary;
            FA = .13 * this.Salary;
            OA = .3 * this.Salary;
            return this.Salary+PA+FA+OA;
        }
    }

    class MarketingExecutive : Employee {
        int TELE = 1000;
        double km = 0;
        public double KM{
            set {
                this.km = value;
            }
        }
        public double Ta {
            get {
                return this.km * 5;
            }
        }
        public override double CalculateSalary()
        {
            return this.Salary + this.km * 5 + TELE;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "Hemanth";
            e1.Salary = 20000;
            e1.print();
            Console.WriteLine("\n");

            Manager e2 = new Manager();
            e2.ID = 2;
            e2.Name = "Phani";
            e2.Salary = 20000;
            e2.print();
            Console.WriteLine("\n");

            MarketingExecutive e3 = new MarketingExecutive();
            e3.ID = 3;
            e3.Name = "Gowthami";
            e3.Salary = 20000;
            e3.KM = 25;
            e3.print();
        }
    }
}
