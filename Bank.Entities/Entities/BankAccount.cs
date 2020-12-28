using System;

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
            get { return balance; }
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
            this.customerName = customerName;
            this.balance = balance;
        }

        // Credito(double amount)
        // Se amount < 0 lançar exception
        // balance += amount
        public double Credito(double amount)
        {
            if(amount < 0)
            {
                throw new Exception("Valor deve ser maior que zero");
            }
            else
            {
                return this.balance += amount;
                
            }
        }

        // Debito(double amount)
        // se amount > balance lançar exception
        // Se amount < 0 lançar exception
        // balance -= amount * 0.025
        public double Debito(double amount)
        {
            if (amount > balance)
            {
                throw new Exception("Saldo insuficiente!");
            }
            else if (amount < 0)
            {
                throw new Exception("Valor deve ser maior que zero");
            }
            else
            {
                return this.balance -= amount * 1.025;
                
            }
        }
    }
}

