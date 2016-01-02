using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    public class Component
    {
        private string name;
        private List<string> details;
        private double price;

        public Component(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Component(string name,double price,List<string>details)
            :this(name,price)
        {
            this.Details = details;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name of component cant be empty string");
                }
                else
                {
                    this.name = value;
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
                if(value <= 0)
                {
                    throw new Exception("Price cannot be 0 or neggative number");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public List<string> Details
        {
            get
            {
                return this.details;
            }
            private set
            {
                this.details = value;
            }
        }
        public override string ToString()
        {
            string output = this.name+" ";
            if(this.details!=null)
            {
                output+="\n"+String.Join(", ", this.details)+"\n";
            }
            output += "- "+this.price + " lv.";
            return output;
        }
    }
}
