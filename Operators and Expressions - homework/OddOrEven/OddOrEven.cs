using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //1. read rom the console
            if (number % 2 == 0) // 2. check if number is devidible by 2 without remainder /if it is even/
            {
                Console.WriteLine("even" + " " + number); //print
            }
            else
            {
                Console.WriteLine("odd" + " " + number); //print
            }
        }
    }
}
