using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray test = new BitArray(8);
            test[1] = 1;
            test[1] = 1;
            test[2] = 1;

            Console.WriteLine(test);
        }
    }
}
