using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore
{
    class LaptopStore
    {
        static void Main(string[] args)
        {
            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", 2259.00, new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5),
                "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8,
                "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");

            Laptop hp = new Laptop("HP 250 G2", 699.00);
            
            Console.WriteLine(lenovo);
            Console.WriteLine(hp);
            hp.Battery(new Battery("mn moshtna", 1));
            Console.WriteLine(hp);
        }
    }
}
