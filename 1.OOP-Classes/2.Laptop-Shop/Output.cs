using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Output
    {
        static void Main(string[] args)
        {

            Laptop laptop = new Laptop("Lenovo Yoga 2 Pro", 200m);
            Console.WriteLine(laptop);

            Laptop laptop1 = new Laptop("Lenovo Yoga 2 Pro", 2000m, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                "Li-Ion, 4-cells, 2550 mAh", 4.5);

            Console.WriteLine(laptop1);

            Console.WriteLine();

            Battery battery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", 200m, null, null, null, null, null, null, battery);
            Console.WriteLine(laptop2);

            Console.WriteLine();
            Battery battery2 = new Battery("Li-Ion, 4-cells, 2550 mAh");
            Laptop laptop3 = new Laptop("Acer 2013l", 3000m, "acer", null, null, null, null, null, battery2);
            Console.WriteLine(laptop3);


        }
    }
}
