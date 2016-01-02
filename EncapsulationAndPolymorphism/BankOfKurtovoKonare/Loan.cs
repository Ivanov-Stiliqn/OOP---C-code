using System;

using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare
{
    public class Loan : Account,IDepositable
    {
        public Loan(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
            
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Customer == Customer.Individual &&months<=3)
            {
                return 0;
            }

            if (this.Customer == Customer.Individual && months <= 2)
            {
                return 0;
            }

            return base.CalculateRate(months);
        }
    }
}
