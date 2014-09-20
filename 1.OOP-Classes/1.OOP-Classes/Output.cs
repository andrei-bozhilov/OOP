using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Output
    {
        static void Main()
        {
            Person person1 = new Person("Petur Pertov", 20);
            Console.WriteLine(person1);

            Person person2 = new Person("Petur Pertov", 20, "asd@");
            Console.WriteLine(person2);



        }
    }
}
