using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName,string lastName,string facultyNumber)
            : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber { 
            get 
            {
                return this.facultyNumber;
            }
            set 
            {
                if(value.Length<5 || value.Length>10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number should be in the range [5-10] digits long");
                }
                else
                {
                    this.facultyNumber = value;
                }
            }
        }
        public override string ToString()
        {
            return "Student: "+base.ToString()+" Faculty number: "+this.facultyNumber;
        }
    }
}
