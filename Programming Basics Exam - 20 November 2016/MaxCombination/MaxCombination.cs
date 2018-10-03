using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class MaxCombination
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endtIndex = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = startIndex; i <= endtIndex; i++)
            {
                for (int j = startIndex; j <= endtIndex; j++)
                {
                    count++;
                    if (count > maxCombinations)
                    {
                        return;
                    }
                    Console.Write($"<{i}-{j}>");
                }
            }
        }
    }
}
