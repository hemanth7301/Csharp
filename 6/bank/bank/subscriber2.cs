using System;
namespace bank
{

    class subscriber2
    {
        private readonly publisher1 pub1;
        public subscriber2(publisher1 pub1)
        {
            this.pub1 = pub1;
            pub1.UnderBalance += UnderBalanceHandler;
        }
        public void UnderBalanceHandler()
        {
            Console.WriteLine("Dear Customer This transaction will create negative balance");
        }
    }
}
