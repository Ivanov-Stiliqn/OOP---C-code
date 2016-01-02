using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Models;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        List<Project> Projects { get; set; }

        void AddProjects(List<Project> projects);

        string ToString();
    }
}
