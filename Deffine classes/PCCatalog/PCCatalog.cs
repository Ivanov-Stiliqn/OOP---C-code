using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            List<String>motherBoardDetails=new List<string>();
            motherBoardDetails.Add("Mnooooo qka");
            motherBoardDetails.Add("Zimai ne mu misli");

            Computer lenovo=new Computer("Lenovo Yoga 2 Pro",new Component("Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",1050),
                new Component("Intel HD Graphics 4400",546),new Component("i7-4510U 2.0GHz CPU 5B20G38213",813,motherBoardDetails),
                new Component("13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",414));

            Computer hp = new Computer("HP 250 G2", new Component("nqkuv", 500),
                new Component("nqkva", 55), new Component("nqkva", 300),
                new Component("nqkuv", 100));

            Computer sony = new Computer("Sony Vaio the best", new Component("moshten", 2000),
                new Component("moshtna", 334), new Component("moshtna", 600),
                new Component("guzarski", 789));

            Computer[] computers = new Computer[3];
            computers[0] = lenovo;
            computers[1] = hp;
            computers[2] = sony;

            double price = lenovo.Price;

            Array.Sort(computers,delegate(Computer pc1, Computer pc2)
                {
                    return pc2.Price.CompareTo(pc1.Price);
                });
            foreach(Computer pc in computers)
            {
                Console.WriteLine(pc);
            }
            
        }
    }
}
