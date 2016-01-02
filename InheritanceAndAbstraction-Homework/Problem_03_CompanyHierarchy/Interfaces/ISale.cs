using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        
        DateTime Data { get; set; }
        
        double Price { get; set; }

        string ToString();
    }
}
