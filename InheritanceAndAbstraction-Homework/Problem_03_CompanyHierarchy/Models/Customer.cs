using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public class Customer :Person,ICustomer
    {
        private double netPurchaseAmount;

        public Customer(string firstName,string lastName,string id,double netPurchaseAmount)
            :base(firstName,lastName,id)
        {
         
            this.NetPurchaseAmount = netPurchaseAmount;
        }
        public double NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentOutOfRangeException("The purchase amount cannot be 0 or neggative");
                }
                else
                {
                    this.netPurchaseAmount = value;
                }
            }
        }

        public void AddPurchases(double purchace)
        {
            this.NetPurchaseAmount += purchace;
        }


        public override string ToString()
        {
            return base.ToString()+"\nNet purchase amount: "+this.netPurchaseAmount;
        }

    }
}
