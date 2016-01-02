using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Animals
{
    public class Tomcat : Cat
    {
        private const Gender gender=Gender.Male;

        public Tomcat(string name,int age)
            :base(name,age,gender)
        {

        }
    }
}
