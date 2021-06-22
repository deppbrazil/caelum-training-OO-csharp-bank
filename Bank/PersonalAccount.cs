namespace Bank
{   
    // Base Class
    public class PersonalAccount
    {
        // Static attribute
        private static int accountNumbers;

        // Number account is automatic generate, so it is private set
        public int AccountNumber { get; private set; }
        
        // So it is protected for manipulation trought son too
        public double Balance { get; protected set; }

        public NewClient OwnerAccount { get; set; }

        // Constructor no accounts argument
        // For automatic generate account number
        public PersonalAccount()
        {
            // Increments the account number everytime create new account 
            PersonalAccount.accountNumbers++;
        }

        public void SendOpValue(double OpValue)
        {
            this.Balance += OpValue;
        }

        // Virtual - for subscribe GetOpValue in Class
        public virtual void GetOpValue(double OpValue)
        {            
            this.Balance -= OpValue;            
        }

        public static int NextAccountNumber()
        {
            return PersonalAccount.accountNumbers + 1;
        }
    }
}