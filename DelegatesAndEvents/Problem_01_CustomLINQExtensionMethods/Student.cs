using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_CustomLINQExtensionMethods
{
    public class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public double Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 1 || value >10)
                {
                    throw new ArgumentOutOfRangeException("grade", "The grade should be in the range [1 - 10]");
                }
                this.grade = value;
            }
        }
    }
}
