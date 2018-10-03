using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int printNumber;
            for (int index = 2; index <= 11; index++)
            {
                if (index % 2 == 0)
                {
                    printNumber = index;
                }
                else
                {
                    printNumber = index * (-1);
                }
                Console.WriteLine(printNumber);
            }
        }
    }
}
