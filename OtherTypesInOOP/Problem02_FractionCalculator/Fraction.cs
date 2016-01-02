using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem02_FractionCalculator
{
    public struct Fraction
    {
        private BigInteger numerator;
        private BigInteger denominator;

        public Fraction(BigInteger numerator, BigInteger denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public BigInteger Numerator
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException("Numberator must be in the range [-9223372036854775808 ... 9223372036854775807]");
                }
                this.numerator = value;
            }
        }

        public BigInteger Denominator
        {
            get
            {
                return this.denominator;
            }
            private set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException("Denominator must be in the range [-9223372036854775808 ... 9223372036854775807]");
                }
                if (value == 0)
                {
                    throw new DivideByZeroException("Cannot divide by 0");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fraction1,Fraction fraction2)
        {
            BigInteger LCD = LeastCommonDiviser(fraction1.Denominator, fraction2.Denominator);

            BigInteger pow1 = LCD/fraction1.Denominator;
            BigInteger pow2 = LCD/fraction2.Denominator;

            BigInteger numerator = fraction1.Numerator*pow1 + fraction2.Numerator*pow2;
            
            return new Fraction(numerator,LCD);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            BigInteger LCD = LeastCommonDiviser(fraction1.Denominator, fraction2.Denominator);

            BigInteger pow1 = LCD / fraction1.Denominator;
            BigInteger pow2 = LCD / fraction2.Denominator;

            BigInteger numerator = fraction1.Numerator * pow1 - fraction2.Numerator * pow2;

            return new Fraction(numerator, LCD);
        }

        private static BigInteger LeastCommonDiviser(BigInteger num1, BigInteger num2)
        {
            for (BigInteger i = 1; i <= num1*num2; i++)
            {
                if (i%num1 == 0 && i%num2 == 0)
                {
                    return i;
                }
            }
            return 0;
        }

        private decimal Result()
        {
            decimal result = (decimal)this.Numerator/(decimal)this.Denominator;
            return result;
        }

        public override string ToString()
        {
            return Result().ToString();
        }
    }
}
