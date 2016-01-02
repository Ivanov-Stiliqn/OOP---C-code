using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace DistanceCalculator
{
    static class DistanceCalculator
    {
        
        public static double CalculateDistance(Point3D.Point3D pointA,Point3D.Point3D pointB)
        {
            double distance= Math.Sqrt(Math.Pow((pointB.X - pointA.X), 2) 
                + Math.Pow((pointB.Y - pointA.Y), 2) 
                + Math.Pow((pointB.Z - pointA.Z), 2));
            return distance;
        }
    }
}
