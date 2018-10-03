using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modify
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine()); // read from the console
            uint positionofbitinnumber = uint.Parse(Console.ReadLine()); // read from the console
            uint bitvalue = uint.Parse(Console.ReadLine()); // read from the console

            ulong maskNumber = (ulong)1 << (int)positionofbitinnumber; // make a mask of number
            ulong bit = ((ulong)number & (ulong)maskNumber) >> (int)positionofbitinnumber; // take the bit ot given position

            if (bit != bitvalue) // check if bit != given bitvalue
            {
                number = number ^ maskNumber; // find the modified number
            }
            Console.WriteLine(number); // print
        }
    }
}
