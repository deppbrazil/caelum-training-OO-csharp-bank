namespace Bank
{
    internal class PersonalAccount
    {
        public int AccountNumber { get; set; }
        public double  Balance { get; set; }
        public NewClient OwnerAccount { get; set; }

        public void SendOpValue(double OpValue)
        {
            this.Balance += OpValue;
        }

        public virtual void GetOpValue(double OpValue)
        {            
            this.Balance -= OpValue;            
        }

    }
}