using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SavingAccount : PersonalAccount
    {
        public override void GetOpValue(double OpValue)
        {
            base.GetOpValue(OpValue + 0.10);
        }

    }
}
