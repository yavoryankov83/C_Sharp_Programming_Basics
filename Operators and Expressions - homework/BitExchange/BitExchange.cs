using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine()); //read from the console
            uint firstBits = (number >> 3) & 7;
            uint secondBits = (number >> 24) & 7;
            uint maskFirstBits = 7 << 3;
            uint maskSecondBits = 7 << 24;
            number = number & ~maskFirstBits | (secondBits << 3);
            number = number & ~maskSecondBits | (firstBits << 24);
            Console.WriteLine(number);
        }
    }
}
