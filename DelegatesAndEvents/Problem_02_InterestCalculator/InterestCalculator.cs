using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_InterestCalculator
{
    public class InterestCalculator
    {
        public delegate decimal CalculateInterest(int money, decimal interest, int years);

        private int money;
        private decimal interest;
        private int years;

        public InterestCalculator(int money, decimal interest, int years, CalculateInterest calculate)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Calculate = calculate;
        }

        public int Money
        {
            get { return this.money; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("money", "Money should be bigger than 0 !");
                }
                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("interest", "Interest should be bigger than 0 !");
                }
                this.interest = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("years", "Years should be bigger than 0 !");
                }
                this.years = value;
            }
        }

        public CalculateInterest Calculate { get; set; }


        public decimal Result()
        {
            return this.Calculate(this.Money, this.Interest, this.Years);
        }
    }
}
