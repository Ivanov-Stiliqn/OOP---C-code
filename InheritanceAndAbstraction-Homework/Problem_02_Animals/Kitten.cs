using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Animals
{
    public class Kitten : Cat
    {
        private const Gender gender=Gender.Female;

        public Kitten(string name, int age)
            : base(name, age, gender)
        {

        }
    }
}
