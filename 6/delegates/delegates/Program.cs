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
        { }
        
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
}
