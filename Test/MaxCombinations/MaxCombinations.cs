using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCount = int.Parse(Console.ReadLine());

            var count = 0;

            for (int first = start; first <= end; first++)
            {
                for (int second = start; second <= end; second++)
                {
                    if (count == maxCount)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"<{first}-{second}>");
                    }
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
