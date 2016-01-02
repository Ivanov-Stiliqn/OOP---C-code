using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Tomcat("Gosho", 3);
            Cat princess = new Kitten("Princess", 2);
            Dog charli = new Dog("Charli", 5, Gender.Male);
            Dog vihur = new Dog("Vihur", 1, Gender.Male);
            Dog sladkishche = new Dog("Sladkishche", 3, Gender.Female);
            Frog jabcho = new Frog("Jabcho", 1, Gender.Female);

            List<Animal> animals = new List<Animal>();
            animals.Add(tom);
            animals.Add(princess);
            animals.Add(charli);
            animals.Add(vihur);
            animals.Add(sladkishche);
            animals.Add(jabcho);

            foreach (var animal in animals)
            {
                animal.SoundProduce();
            }

            Console.WriteLine();

            double catsAverage = animals
                .Where(animal => animal is Cat)
                .Average(cat => cat.Age);

            double dogsAverage = animals
                .Where(animal => animal is Dog)
                .Average(dog => dog.Age);

            double frogsAverage = animals
                .Where(animal => animal is Frog)
                .Average(frog => frog.Age);

            Console.WriteLine("Average cats age: {0:F2}", catsAverage);
            Console.WriteLine("Average dogs age: {0:F2}", dogsAverage);
            Console.WriteLine("Average frogs age: {0:F2}", frogsAverage);
        }
    }
}
