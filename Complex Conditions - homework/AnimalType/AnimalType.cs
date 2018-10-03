using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            if (name == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (name == "crocodile" || name == "tortoise" || name == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
