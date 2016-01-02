using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine("Point coordinates: "+point);
            Console.WriteLine("Starting point: "+point.StarttingPoint);
        }
    }
}
