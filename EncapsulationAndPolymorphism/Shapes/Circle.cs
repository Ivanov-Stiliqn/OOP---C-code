using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be 0 or neggative");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI*Math.Pow(this.radius, 2);

            return area;
        }

        public double CalculatePerimetur()
        {
            double perimeter = 2*Math.PI*this.radius;

            return perimeter;
        }
    }
}
