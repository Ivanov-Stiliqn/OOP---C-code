using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Models;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }

        void AddSales(List<Sale> sales);

        string ToString();
    }
}
