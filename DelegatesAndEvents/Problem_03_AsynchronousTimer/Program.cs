using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remaining time: 10");
            Console.WriteLine();

            AsyncTimer timer = new AsyncTimer(TickTaking,10,1500);
            timer.ExecuteAction();

        }

        public static void TickTaking(int seconds)
        {
            Console.WriteLine("Remaining time: "+seconds);
            Console.WriteLine();
        }
    }
}
