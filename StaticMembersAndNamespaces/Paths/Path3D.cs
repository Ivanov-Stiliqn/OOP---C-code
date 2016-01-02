using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace Paths
{
    class Path3D
    {
        static void Main(string[] args)
        {
            List<Point3D.Point3D> path = new List<Point3D.Point3D>();
            Point3D.Point3D pointA = new Point3D.Point3D(5, 6, 7);
            Point3D.Point3D pointB = new Point3D.Point3D(6, 8, 9);
            Point3D.Point3D pointC = new Point3D.Point3D(11, 13, 20);
            Point3D.Point3D pointD = new Point3D.Point3D(1, 2, 3);
            Point3D.Point3D pointE = new Point3D.Point3D(21, 23, 24);

            path.Add(pointA);
            path.Add(pointB);
            path.Add(pointC);
            path.Add(pointD);
            path.Add(pointE);

            //Storage.Save(path);

            List<Point3D.Point3D> resultFromLoad = Storage.Load();

            Console.WriteLine("Loadded Points: ");
            foreach (var point in resultFromLoad)
            {
                Console.WriteLine(point);
            }
        }
    }
}
