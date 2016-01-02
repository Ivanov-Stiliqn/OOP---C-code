using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double lenght;

        protected BasicShape(double width, double lenght)
        {
            this.Width = width;
            this.Lenght = lenght;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be 0 or neggative");
                }
                this.width = value;
            }
        }

        public double Lenght
        {
            get { return this.lenght; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Lenght cannot be 0 or neggative");
                }
                this.lenght = value;
            }
        }

        public abstract double CalculateArea();
                         
        public abstract double CalculatePerimetur();

    }
}
