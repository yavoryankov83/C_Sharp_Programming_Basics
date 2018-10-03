using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                var leftSide = row;
                var rightSide = n - 1;

                for (int col = 1; col <= n; col++)
                {
                    if (leftSide <= n)
                    {
                        Console.Write("{0} ", leftSide);
                        leftSide++;
                    }
                    else
                    {
                        Console.Write("{0} ", rightSide);
                        rightSide--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
