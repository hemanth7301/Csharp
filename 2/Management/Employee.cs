using System;

namespace LitwareLib
{
    public class Employee
    {
        private int Emp_No;
        string Emp_Name;
        double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;
        public int EmpNo
        {
            set
            {
                this.Emp_No = value;
            }
            get
            {
                return this.Emp_No;
            }
        }
        public string EmpName
        {
            set
            {
                this.Emp_Name = value;
            }
            get
            {
                return this.Emp_Name;
            }
        }
        public double Sal
        {
            set
            {
                this.Salary = value;
                if (this.Salary < 5000)
                {
                    this.HRA = 0.1 * value;
                    this.TA = 0.5 * value;
                    this.DA = 0.15 * value;
                }
                else if (this.Salary < 10000)
                {
                    this.HRA = 0.15 * value;
                    this.TA = 0.1 * value;
                    this.DA = 0.20 * value;
                }
                else if (this.Salary < 15000)
                {
                    this.HRA = 0.2 * value;
                    this.TA = 0.15 * value;
                    this.DA = 0.25 * value;
                }
                else if (this.Salary < 20000)
                {
                    this.HRA = 0.25 * value;
                    this.TA = 0.20 * value;
                    this.DA = 0.30 * value;
                }
                else if (this.Salary >= 20000)
                {
                    this.HRA = 0.30 * value;
                    this.TA = 0.25 * value;
                    this.DA = 0.35 * value;
                }
                this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            }
            get
            {
                return this.GrossSalary;
            }
        }
        public double CalculateSalary()
        {
            this.PF = 0.1 * this.GrossSalary;
            this.TDS = .18 * this.GrossSalary;
            this.NetSalary = this.GrossSalary - (this.TDS + this.PF);
            return this.NetSalary;
        }
    }
}



