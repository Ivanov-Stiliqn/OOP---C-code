using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D.Point3D pointA = new Point3D.Point3D(5, 6, 2);
            Point3D.Point3D pointB = new Point3D.Point3D(-7, 11, -13);

            Console.WriteLine("The distance between {0} , {1} is: \n{2}",pointA,pointB,DistanceCalculator.CalculateDistance(pointA,pointB));
        }
    }
}
