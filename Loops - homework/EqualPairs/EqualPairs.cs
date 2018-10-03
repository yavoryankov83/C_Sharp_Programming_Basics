using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class EqualPairs
    {
        static int MaxDiff(List<int> Sums)
        {
            int diff = 0;
            int Maxdiff = int.MinValue;
            for (int i = 0; i < Sums.Count - 1; i++)
            {
                diff = Math.Abs(Sums[i] - Sums[i + 1]);
                if (diff > Maxdiff)
                {
                    Maxdiff = diff;
                }
            }
            return Maxdiff;
        }

        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var numbers = new List<int>(2 * count);
            var sums = new List<int>(count);
            var sum = 0;

            for (int i = 0; i < 2 * count; i++)
            {
                var num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                sum = numbers[i] + numbers[i + 1];
                sums.Add(sum);
            }

            int maxDiff = MaxDiff(sums);
            
            Console.WriteLine(maxDiff == 0 || maxDiff == int.MinValue ? $"Yes, value={sums.First()}" : $"No, maxdiff={maxDiff}");
        }
    }
}
