using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03_CompanyHierarchy.Models;
using Problem_03_CompanyHierarchy.Interfaces;

namespace Problem_03_CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> ivanSales = new List<Sale>();
            ivanSales.Add(new Sale("product", new DateTime(2015, 2, 3), 1005.0));
            ivanSales.Add(new Sale("product", new DateTime(2015, 4, 12), 735.80));
            ivanSales.Add(new Sale("product", new DateTime(2015, 10, 8), 333.50));
            SalesEmployee ivan = new SalesEmployee("Ivan", "Dimov", "9002128830", 750.00, Department.Sales,ivanSales);


            SalesEmployee georgi = new SalesEmployee("Georgi", "Georgiev", "9003159031", 750.00, Department.Sales);
            georgi.AddSales(new List<Sale>
            {
                new Sale("product", new DateTime(2015, 4, 5), 1005.0),
                new Sale("product", new DateTime(2015, 3, 11), 735.80),
                new Sale("product", new DateTime(2015, 5, 8), 333.50)
            });

            Manager stanimir = new Manager("Stanimir", "Marinov", "8505177680", 1300.50, Department.Sales);
            stanimir.AddEmployees(new List<Employee> { ivan, georgi });

            List<Project>stoilProjects=new List<Project>();
            stoilProjects.Add(new Project("project",new DateTime(2015, 5, 6),State.open));
            Developer stoil=new Developer("Stoil","Karamfilov","9303029050",1100,Department.Production,stoilProjects);

            List<Project>kamenProjects=new List<Project>();
            kamenProjects.Add(new Project("project",new DateTime(2015, 8,10),State.closed,"OOP rocks"));
            RegularEmployee kamen = new Developer("Kamen", "Vodenicharov", "8302078861", 1200, Department.Production, kamenProjects);

            Customer customer = new Customer("Ivelin", "Galinov", "9312129045", 2458.30);
            customer.AddPurchases(2000);

            List<Person> persons = new List<Person> 
            {
            ivan, georgi, stanimir, stoil, kamen, customer
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
