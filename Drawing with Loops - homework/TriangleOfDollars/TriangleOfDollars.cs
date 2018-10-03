using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            var dollars = int.Parse(Console.ReadLine());

            for (int row = 1; row <= dollars; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("$");
                    if (col < dollars)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
