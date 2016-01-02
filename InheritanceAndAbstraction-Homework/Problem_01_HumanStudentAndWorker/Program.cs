using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Dimitrov", "121410"));
            students.Add(new Student("Georgi", "Georgiev", "121403"));
            students.Add(new Student("Jivko", "Dimitrov", "121408"));
            students.Add(new Student("Aneliq", "Ivanova", "121405"));
            students.Add(new Student("Monika", "Karaivanova", "121401"));
            students.Add(new Student("Kristiqn", "Hristov", "121404"));
            students.Add(new Student("Dimitur", "Dobrev", "121406"));
            students.Add(new Student("Ivan", "Deliatanasov", "121402"));
            students.Add(new Student("Jivka", "Atanasova", "121407"));
            students.Add(new Student("Rosica", "Karamfilova", "121409"));

            students.Sort((x, y) => x.FacultyNumber.CompareTo(y.FacultyNumber));
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            List<Worker>workers=new List<Worker>();
            workers.Add(new Worker("Ivan","Mamov",100,5));
            workers.Add(new Worker("Petur","Petrov",300,12));
            workers.Add(new Worker("Ana","Mihailova",200,8));
            workers.Add(new Worker("Galin","Dimitrov",440,10));
            workers.Add(new Worker("Mariq","Mihova",250,8));
            workers.Add(new Worker("Stanimir","Marionov",500,12));
            workers.Add(new Worker("Yordan","Kmetov",700,12));
            workers.Add(new Worker("Denica","Pchelarova",500,8));
            workers.Add(new Worker("Atanas","Kolev",200,13));
            workers.Add(new Worker("Dobri","Dobrev",600,15));

            workers.Sort((x,y)=>y.MoneyPerHour().CompareTo(x.MoneyPerHour()));

            Console.WriteLine();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            List<Human>result=humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine();
            foreach(var human in result)
            {
                Console.WriteLine(human);
            }

        }
    }
}
