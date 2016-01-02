using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_InterestCalculator
{
    public class Program
    {
        private const int N = 12;

        public static void Main()
        {
            
            InterestCalculator compound=new InterestCalculator(500,0.056m,10,GetCompoundInterest);
            Console.WriteLine(compound.Result());

            InterestCalculator simple=new InterestCalculator(2500,0.072m,15,GetSimpleInterest);
            Console.WriteLine(simple.Result());
            
        }

        public static decimal GetSimpleInterest(int money, decimal interest, int years)
        {
            return decimal.Round(money * (1 + interest * years),4);
        }

        public static decimal GetCompoundInterest(int money, decimal interest, int years)
        {
            

            return decimal.Round((decimal)(money * Math.Pow((double)(1 + interest / N), N * years)),4);
        }
    }
}
