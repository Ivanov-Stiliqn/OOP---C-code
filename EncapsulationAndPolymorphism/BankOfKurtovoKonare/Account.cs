
using System;

namespace BankOfKurtovoKonare
{
    public abstract class Account
    {
     
        private decimal interestRate; 

        protected Account(decimal balance, decimal interestRate,Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal InterestRate 
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be neggative");
                }
                this.interestRate = value;
            } 
        }

        public decimal Balance { get; set; }

        public Customer Customer { get; set; }

        public virtual decimal CalculateRate(int months)
        {
            decimal money = this.Balance;
            decimal rate = money*(1 + this.interestRate*months);

            return rate;
        }
    }
}
