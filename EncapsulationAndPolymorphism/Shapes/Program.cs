using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4, 5);

            Rhobus rhobus = new Rhobus(3);

            Circle circle = new Circle(5);

            List<IShape> shapes = new List<IShape>()
            {
                circle,
                rhobus,
                rectangle
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name+":\n"+"Perimeter: "+shape.CalculatePerimetur()+" Area: "+shape.CalculateArea());
                Console.WriteLine();
            }
        }
    }
}
