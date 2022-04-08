using System;
namespace bank
{
    
    class subscriber1
    {
        private readonly publisher1 pub1;
        public subscriber1 (publisher1 pub1)
        {
            this.pub1 = pub1;
            pub1.OnBalanceZero += BalanceZeroHandler;
        }
        public void BalanceZeroHandler()
        {
            Console.WriteLine("Dear Customer Your balance is NILL");
        }
    }
}
