using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //read

            for (int i = 1; i <= N; i++) //make a loop from 1 to N
            {
                Console.WriteLine(i); //print
            }
        }
    }
}
