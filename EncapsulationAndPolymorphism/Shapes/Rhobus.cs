using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rhobus : BasicShape
    {
        public Rhobus(double width)
            :base(width,width)
        {
            
        }

        public override double CalculateArea()
        {
            double area = Math.Pow(this.Width, 2)*Math.Sin(this.Width);

            return area;
        }

        public override double CalculatePerimetur()
        {
            double perimeter = 4*this.Width;

            return perimeter;
        }
    }
}
