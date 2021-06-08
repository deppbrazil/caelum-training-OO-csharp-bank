namespace Bank
{   
    // Base Class
    public class PersonalAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public NewClient OwnerAccount { get; set; }       

        public void SendOpValue(double OpValue)
        {
            this.Balance += OpValue;
        }

        // Virtual - for subscribe GetOpValue in Class
        public virtual void GetOpValue(double OpValue)
        {            
            this.Balance -= OpValue;            
        }

    }
}