using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;

        protected Animal(string name,int age,Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        { 
            get 
            {
                return this.name;
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
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
            set 
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be neggative");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Gender Gender { get; set; }


        public abstract void SoundProduce();
    }
}
