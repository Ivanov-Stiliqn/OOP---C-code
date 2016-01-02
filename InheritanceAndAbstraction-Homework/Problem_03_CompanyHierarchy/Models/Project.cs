using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy.Models
{
    public class Project : IProject
    {
        private string projectName;

        public Project(string projectName, DateTime projectStartDate, State state, string details = null)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }
        public string ProjectName 
        {
            get
            {
                return this.projectName;
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project's name cannot be empty");
                }
                else
                {
                    this.projectName = value;
                }
            }
        }
        public DateTime ProjectStartDate { get; set; }

        public string Details { get; set; }

        public State State { get; set; }

        public void CloseProject()
        {
            this.State = State.closed;
        }
        public override string ToString()
        {
            string output = "";
            if (this.Details != null)
            {
                output += " Details: "+this.Details;
            }
            return "Project: "+this.projectName+" Start at: "+this.ProjectStartDate.Date+" State:"+this.State+output;
            
        }
    }
}
