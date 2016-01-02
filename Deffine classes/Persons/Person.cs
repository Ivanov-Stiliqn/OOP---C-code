using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age) : this(name,age,null)
        {
           
        }
       
        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null || value.Length < 1 || value.Length > 100)
                {
                    throw new Exception("Name lenght should be in rage [1-100] !");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int Age
        {
            get 
            {
                return this.age;
            }
            private set 
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Age should be between 1 and 100 !");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            private set 
            {
                if (value!=null && !value.Contains('@'))
                {
                    throw new Exception("Invalid email addres !");
                }
                else
                {
                    this.email = value;
                }
            }

        }

        public string toString() 
        {
            if (this.email == null)
            {
                return string.Format("My name is {0}, {1} years old",this.name,this.age);
            }
            else
            {
                return string.Format("My name is {0}, {1} years old and my email is {2}",this.name,this.age,this.email);
            }
        }
       
    }
}
