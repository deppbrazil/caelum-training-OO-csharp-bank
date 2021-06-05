using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SavingAccount : PersonalAccount
    {
        public SavingAccount()
        {

        }
        public SavingAccount(int AccountNumber): base(AccountNumber)
        {

        }
        public override void GetOpValue(double OpValue)
        {
            base.GetOpValue(OpValue + 0.10);
        }

    }
}
