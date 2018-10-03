using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magycNumber = int.Parse(Console.ReadLine());

            var count = 0;
            var isFound = false;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    count++;
                    if (i + j == magycNumber)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magycNumber})");
                        return;
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magycNumber}");
            }
        }
    }
}
