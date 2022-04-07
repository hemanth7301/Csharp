using System;
namespace bank
{
    class publisher1
    {
        public delegate void BalanceZeroHandler();
        public delegate void UnderBalanceHandler();
        public event BalanceZeroHandler OnBalanceZero;
        public event UnderBalanceHandler UnderBalance;
        public void Zero() {
            if (OnBalanceZero != null){
                OnBalanceZero();
                }
            }
        public void negative()
        {
            if (UnderBalance != null)
            {
                UnderBalance();
            }
        }
    }
    }
