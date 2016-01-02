using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    interface ICustomer
    {
        double NetPurchaseAmount { get; set; }

        void AddPurchases(double purchace);

        string ToString();
    }
}
