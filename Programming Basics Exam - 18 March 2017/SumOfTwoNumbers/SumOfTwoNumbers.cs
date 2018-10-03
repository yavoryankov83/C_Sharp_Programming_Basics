using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());

            var count = 0;
            var isThere = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (i + j == magic)
                    {
                        isThere = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = { magic})");
                        return;
                    }  
                }
            }
            if (isThere == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
