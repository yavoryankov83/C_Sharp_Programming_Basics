using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //1. read from the console
            if (number % 7 == 0 && number % 5 == 0) //2. check if number is devidible by 7 and 5 at the same time without a reminder
            {
                Console.WriteLine("true" + " " + number); //print
            }
            else
            {
                Console.WriteLine("false" + " " + number); //print
            }
        }
    }
}
