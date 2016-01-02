using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public class Manager :Employee,IManager
    {

        public Manager(string firstName,string lastName,string id,double salary,Department department,List<Employee>emplyoees=null)
            :base(firstName,lastName,id,salary,department)
        {
            this.Employees = emplyoees ?? new List<Employee>();
        }
        public List<Employee> Employees { get; set; }

        public void AddEmployees(List<Employee> addEmployees)
        {
            foreach (var employee in addEmployees)
            {
                this.Employees.Add(employee);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\nEmplyoees: \n");
            foreach (var emplyoee in this.Employees)
            {
                output.AppendFormat("{0} {1}\n", emplyoee.FirstName,emplyoee.LastName);
            }
            return base.ToString()+output;
        }

    }
}
