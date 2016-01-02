using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Point3D;

namespace Paths
{
    static class Storage
    {
        private const string path = "../../text.txt";

        public static void Save(List<Point3D.Point3D>listOfpoints)
        {
            using(StreamWriter file=new StreamWriter(path))
            {
                foreach (var point in listOfpoints)
                {
                    file.WriteLine(point);
                }
            }
        }

        public static List<Point3D.Point3D> Load()
        {
            List<Point3D.Point3D> listOfPoints = new List<Point3D.Point3D>();

            using(StreamReader file=new StreamReader(path))
            {
                string line = "";
                while((line=file.ReadLine())!=null)
                {
                    line = line.Replace('{', ' ');
                    line = line.Replace('}', ' ');
                    line=line.Replace(" ","");

                    string[] lineArgs = line.Split(new char[] { ','});
                    Point3D.Point3D point = new Point3D.Point3D(double.Parse(lineArgs[0]), double.Parse(lineArgs[1]), double.Parse(lineArgs[2]));
                    listOfPoints.Add(point);
                }
            }
            return listOfPoints;
        }
    }
}
