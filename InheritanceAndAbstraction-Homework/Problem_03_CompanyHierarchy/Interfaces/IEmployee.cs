using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Models;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    public interface IEmployee : IPerson
    {
         double Salary { get; set; }
         Department Department { get; set; }

         string ToString();
    }
}
