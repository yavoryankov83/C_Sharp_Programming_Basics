using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int printSequence;
            for (int number = 2; number < 1002; number++)
            {
                if (number % 2 == 0)
                {
                    printSequence = number;
                }
                else
                {
                    printSequence = number * (-1);
                }
                Console.WriteLine(printSequence);
            }
        }
    }
}
