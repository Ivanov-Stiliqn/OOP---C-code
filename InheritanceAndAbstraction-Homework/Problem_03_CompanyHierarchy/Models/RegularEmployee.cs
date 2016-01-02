using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public abstract class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName,string lastName,string id,double salary,Department department)
            :base(firstName,lastName,id,salary,department)
        {

        }
    }
}
