using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Output
    {
        static void Main(string[] args)
        {
            Components motherboard = new Components("Motherboard", 20);
            Components cpu = new Components("CPU", 40);

            Computer comp = new Computer("asus", 50, motherboard, cpu);
            comp.Components.Add(motherboard);


        }
    }
}
