using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Interfaces;
using System.Text.RegularExpressions;

namespace Problem_03_CompanyHierarchy.Models
{
    public abstract class Person :IPerson
    {
        private string firstName;
        private string lastName;
        private string id;

        protected Person(string firstName,string lastName,string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (!Regex.IsMatch(value,@"(([a-zA-Z]*\d*){6,11})"))
                {
                    throw new ArgumentNullException("ID lenght must be in the range [6-10] and must contain only symbols and digits");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder output=new StringBuilder();
            output.AppendFormat("Position: {0}\n",this.GetType().Name);
            output.AppendFormat("Name: {0} {1}\n",this.firstName,this.lastName);
            output.AppendFormat("ID: {0}",this.id);

            return output.ToString();
        }
    }
}
