using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{   // SavingAccount inherit PersonalAccount
    class SavingAccount : PersonalAccount
    {
        // Overrride subscribe GetOpValue method
        public override void GetOpValue(double OpValue)
        {
            base.GetOpValue(OpValue + 0.10);
        }
    }
}
