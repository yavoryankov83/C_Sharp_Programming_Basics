using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1To100
{
    class NumbersFrom1To100
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
