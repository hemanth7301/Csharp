using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            bank b1 = new bank();
            b1.no = 93939999999;
            b1.bal = 5000;
            b1.name = "hemanth";

            Console.WriteLine("Customer no {0} Customer Name {1} Balance {2}", b1.no,b1.name, b1.bal);
            
            b1.Withdraw(1000);// available 4000
            
            b1.Withdraw(4000);// this raises onzero event

            b1.Withdraw(5000);// this raises underbalance event

            b1.Deposit(50); //available 50
        }
    }
}
