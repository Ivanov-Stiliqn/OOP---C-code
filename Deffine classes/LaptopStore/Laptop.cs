using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string proccessor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double price;
        private Battery battery;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, double price, string manufacturer, Battery batt)
            :this(model,price)
        {
            this.Manufacturer = manufacturer;
            this.battery = batt;
        }
        public Laptop(string model,double price,Battery battery,string manufacturer=null,string proccessor=null,int ram=0,string graphicsCard=null,string hdd=null,string screen=null)
            :this(model,price,manufacturer,battery)
        {
            this.Proccessor = proccessor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;

        }
        

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value == " ")
                {
                    throw new Exception("Model cannot be empty string");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if(value==" ")
                {
                    throw new Exception("Manufacturer cannot be empty string");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public string Proccessor
        {
            get
            {
                return this.proccessor;
            }
            private set
            {
                if (value == " ")
                {
                    throw new Exception("Proccessor cannot be empty string");
                }
                else
                {
                    this.proccessor = value;
                }
            }
        }
        public int RAM
        {
            get
            {
                return this.ram;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("RAM cannot be neggative number");
                }
                else
                {
                    this.ram = value;
                }
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            private set
            {
                if (value == " ")
                {
                    throw new Exception("Graphics Card cannot be empty string");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            private set
            {
                if (value == " ")
                {
                    throw new Exception("HDD cannot be empty string");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            private set
            {
                if (value == " ")
                {
                    throw new Exception("Screen cannot be empty string");
                }
                else
                {
                    this.screen = value;
                }
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0.0)
                {
                    throw new Exception("Price cannot be neggative number");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public void Battery(Battery battery)
        {
            this.battery=battery;
        }

        public override string ToString()
        {
            string output = "Model: " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manufacturer))
            {
                output += "Manufacturer: " + this.manufacturer + "\n";
            }
            if (!String.IsNullOrEmpty(this.proccessor))
            {
                output += "Proccessor: " + this.proccessor + "\n";
            }
            if (this.ram != 0)
            {
                output += "RAM: " + this.ram + " GB\n";
            }
            if (!String.IsNullOrEmpty(this.graphicsCard))
            {
                output += "Graphics card: " + this.graphicsCard + "\n";
            }
            if (!String.IsNullOrEmpty(this.hdd))
            {
                output += "HDD: " + this.hdd + "\n";
            }
            if (!String.IsNullOrEmpty(this.screen))
            {
                output += "Screen: " + this.screen + "\n";
            }
            output += this.battery + "\n";
            output += "Price: " + this.price + " lv.\n";
            return output;
        }
    }
}
