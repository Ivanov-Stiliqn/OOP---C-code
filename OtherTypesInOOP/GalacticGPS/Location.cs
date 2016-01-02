using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            private set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be in the range [-90 90]");
                    
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            private set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude must be in the range [-90 90]");

                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.latitude, this.longitude, this.Planet);
        }
    }
}
