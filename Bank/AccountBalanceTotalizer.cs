using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class AccountBalanceTotalizer
    {
        public double TotalValue { get; private set; }

        public void SumValue(PersonalAccount AccountNumber)
        {
            this.TotalValue += AccountNumber.Balance;
        }
        public void SumValue(SavingAccount AccountNumber)
        {
            this.TotalValue += AccountNumber.Balance;
        }

    }
}
