namespace dotbank_co
{
    public class Account
    {
        private AccountType AccountType{ get; set;}
        private double Amount { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }

        // Constructor Method called when the account is created
        public Account(AccountType accountType, double amount, double credit, string name)
        {
            this.AccountType = accountType;
            this.Amount = amount;
            this.Credit = credit;
            this.Name = name;
        }
        
    }
}