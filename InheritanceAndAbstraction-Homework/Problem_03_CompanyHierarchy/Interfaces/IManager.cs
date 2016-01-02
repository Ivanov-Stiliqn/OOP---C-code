using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Models;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        List<Employee> Employees{ get; set; }

        void AddEmployees(List<Employee> addEmployees);

        string ToString();

    }
}
