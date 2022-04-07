using System;
namespace bank
{
    public class bank
    {
        long account_number;
        int balance;
        string customer_name;
        public long no
        {
            get { return this.account_number; }
            set { this.account_number = value; }
        }
        public int bal
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string name
        {
            get { return this.customer_name; }
            set { this.customer_name = value; }
        }

        public void Withdraw(int rupees)
        {
            this.balance -= rupees;
            if (this.balance == 0)
            {
                publisher1 p1 = new publisher1();
                subscriber1 s1 = new subscriber1(p1);
                p1.Zero();
            }
            else if (this.balance < 0)
            {
                this.balance += rupees;
                publisher1 p1 = new publisher1();
                subscriber2 s2 = new subscriber2(p1);
                p1.negative();
            }
            else
            {
                Console.WriteLine("Amount withdrawed !!! Avail Bal {0} for Customer {1}", this.balance, this.customer_name);
            }
        }

        public void Deposit(int rupees)
        {
            this.balance += rupees;
            Console.WriteLine("Amount Deposited !!! Avail Bal {0}  for Customer {1}", this.balance, this.customer_name);
        }
    }
}
