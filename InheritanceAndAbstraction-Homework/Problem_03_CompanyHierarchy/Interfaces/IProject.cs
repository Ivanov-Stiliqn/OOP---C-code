using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Models;

namespace Problem_03_CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }

        DateTime ProjectStartDate { get; set; }

        string Details { get; set; }

        State State { get; set; }

        string ToString();
    }
}
