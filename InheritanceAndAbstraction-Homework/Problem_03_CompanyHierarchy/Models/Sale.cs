using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public class Sale : ISale
    {
        private string productName;
        private double price;

        public Sale(string productName,DateTime data,double price)
        {
            this.ProductName = productName;
            this.Data = data;
            this.Price = price;
        }

        public string ProductName 
        {
            get 
            {
                return this.productName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product's name cannot be empty");
                }
                else
                {
                    this.productName = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be 0 or neggative");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public DateTime Data { get; set; }

        public override string ToString()
        {
            return "Product: "+this.productName+" Data: "+this.Data+" Price: "+this.price;
        }
    }
}
