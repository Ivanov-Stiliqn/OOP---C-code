using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore
{
    public class Battery
    {
        private string batteryModel;
        private double batteryLife;

        public Battery(string model,double batteryLife)
        {
            this.BatteryModel = model;
            this.BatteryLife = batteryLife;

        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if(value==" ")
                {
                    throw new Exception("Battery model cannot be empty string");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }
        
        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if(value<0)
                {
                    throw new Exception("Battery Life cannot be neggative number");

                }
                else
                {
                    this.batteryLife = value;
                }
            }
        }

        public override string ToString()
        {
            return "Battery: " + this.batteryModel + "\nBattery life: " + this.batteryLife+" hours";
        }
    }
}
