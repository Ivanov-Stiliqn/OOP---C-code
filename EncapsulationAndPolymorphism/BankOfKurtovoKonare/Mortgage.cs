
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare
{
    public class Mortgage : Account,IDepositable
    {
        public Mortgage(decimal balance, decimal interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
            
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateRate(int months)
        {
            if (this.Customer == Customer.Individual && months<=6)
            {
                return 0;
            }

            if (this.Customer == Customer.Company && months <= 12)
            {
                return base.CalculateRate(months)/2;
            }

            return base.CalculateRate(months);


        }
    }
}
