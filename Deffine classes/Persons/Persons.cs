using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            Person gosho = new Person("Gosho", 12, "gosho12@abv.bg");
            Person pesho = new Person("Pesho", 21, "peshkataWWE@hotmail.bg");
            Person mitaka = new Person("Mitko", 8);
            Person[] persons = new Person[3];
            persons[0] = gosho;
            persons[1] = pesho;
            persons[2] = mitaka;
            foreach (Person human in persons)
            {
                Console.WriteLine(human.toString());
            }
        }
    }
}
