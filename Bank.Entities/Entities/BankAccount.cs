namespace Bank.Entities.Entities
{
    public class BankAccount : IBankAccount
    {
        private string customerName;
        private double balance;
        public string CustomerName
        {
            get { return this.customerName; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void SetNameOfCustomer(string name)
        {
            this.customerName = name;
        }

        public double AddInterest(double interest)
        {
            return this.balance *= interest;
        }

        public BankAccount()
        {

        }
        public BankAccount(string customerName, double balance)
        {
            customerName = customerName;
            balance = balance;
        }

        // Credito(double amount)
        // Se amount < 0 lançar exception
        // balance += amount


        // Debito(double amount)
        // se amount > balance lançar exception
        // Se amount < 0 lançar exception
        // balance -= amount * 0.025

    }
}

