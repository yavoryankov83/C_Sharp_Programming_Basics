using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // read
            int b = int.Parse(Console.ReadLine()); // read
            int c = int.Parse(Console.ReadLine()); // read
            int d = int.Parse(Console.ReadLine()); // read
            int e = int.Parse(Console.ReadLine()); // read

            int sum = a + b + c + d + e; //sum numbers

            Console.WriteLine(sum); //print
        }
    }
}
