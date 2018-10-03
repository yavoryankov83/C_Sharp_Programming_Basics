using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string name = "World";
            object fullGreeting = greeting + " " + name;
            string again = (string)fullGreeting;
            Console.WriteLine(again);

        }
    }
}
