using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public class SalesEmployee :RegularEmployee,ISalesEmployee
    {
        public SalesEmployee(string firstName,string lastName,string id,double salary,Department department,List<Sale>sales=null)
            :base(firstName,lastName,id,salary,department)
        {
            this.Sales = sales ?? new List<Sale>();
        }

        public List<Sale> Sales { get; set; }

        public void AddSales(List<Sale> sales)
        {
            foreach (var sale in sales)
            {
                this.Sales.Add(sale);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\nSales: \n");
            foreach (var sale in this.Sales)
            {
                output.AppendFormat("{0}\n", sale);
            }
            return base.ToString() + output;
        }
    }
}
