using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double lenght)
            : base(width, lenght)
        {
            
        }

        public override double CalculateArea()
        {
            double area = this.Width*this.Lenght;
            return area;
        }

        public override double CalculatePerimetur()
        {
            double perimeter = (this.Width + this.Lenght)*2;
            return perimeter;
        }
    }
}
