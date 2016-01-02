using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        private static int count;

        static void Main(string[] args)
        {
            count = 0;
            Console.WriteLine("You must enter 10 INTEGER numbers such as [ previous < next < 100 ]");
            ReadNumber(1, 100);
        }
        private static void ReadNumber(int start,int end)
        {
            int number = 0;

            if (count == 10)
            {
                return;
            }
            Console.WriteLine("({2}) Enter a integer number between {0} and {1}",start,end,count+1);
            try
            {
                number = int.Parse(Console.ReadLine());
                if(number<=start || number >=end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if(number==end-1 && count < 9)
                {
                    throw new ArgumentException ();
                }
                else
                {
                    start = number;
                    count++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number !");
                ReadNumber(start, end);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The integer number you have entered is outside the range [{0},{1}]",start,end);
                ReadNumber(start, end);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("You have entered only {2} number and \nthere is no next integer number in the range [{0},{1}]",number,end,count+1);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
                ReadNumber(start, end);
            }
            finally
            {
                ReadNumber(start, end);
            }
        }
    }
}
