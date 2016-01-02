using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public abstract class Employee : Person,IEmployee
    {
        private double salary;

        public Employee(string firstName,string lastName,string id,double salary,Department department)
            :base(firstName,lastName,id)
        {
            this.Salary = salary;
            this.Department = department;
        }
        
        public double Salary 
        {
            get 
            {
                return this.salary;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be neggative");
                }
                else 
                {
                    this.salary = value;
                }
            }
        }
        public Department Department { get; set; }

        public override string ToString()
        {
            return base.ToString()+"\nSalary: "+this.salary+"\nDepartment: "+this.Department;
        }
    }
}
