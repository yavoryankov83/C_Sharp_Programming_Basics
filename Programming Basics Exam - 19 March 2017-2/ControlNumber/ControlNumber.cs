using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            var movesCount = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += (i * 2 + j * 3);
                    movesCount++;

                    if (sum >= controlNumber)
                    {
                        Console.WriteLine("{0} moves", movesCount);
                        Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (sum < controlNumber)
            {
                Console.WriteLine("{0} moves", movesCount);
            }
        }
    }
}
