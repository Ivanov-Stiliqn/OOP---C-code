using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter possitve INTEGER number: ");
                int number = int.Parse(Console.ReadLine());
                if(number<0)
                {
                    throw new ArgumentException();
                }
              
                Console.WriteLine("The square root of {0} is: {1}",number,Math.Sqrt(number));
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is out of integer boundries");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Number cannot be neggative");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye !");
            }
        }
    }
}
