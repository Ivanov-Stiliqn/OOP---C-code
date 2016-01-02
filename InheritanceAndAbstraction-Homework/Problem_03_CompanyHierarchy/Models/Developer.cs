using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public class Developer : RegularEmployee,IDeveloper
    {
        public Developer(string firstName,string lastName,string id,double salary,Department department,List<Project>projects=null)
            :base(firstName,lastName,id,salary,department)
        {
            this.Projects = projects ?? new List<Project>();
        }

        public List<Project> Projects { get; set; }

        public void AddProjects(List<Project> projects)
        {
            foreach (var project in projects)
            {
                this.Projects.Add(project);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\nProject: \n");
            foreach (var project in this.Projects)
            {
                output.AppendFormat("{0}\n", project);
            }
            return base.ToString() + output;
        }
    }
}
