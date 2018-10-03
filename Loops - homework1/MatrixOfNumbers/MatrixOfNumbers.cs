using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());

            for (int row = 0; row < N; row++)
            {
                for (int column = 1; column <= N; column++)
                {
                    Console.Write("{0} ", row + column);
                }
                Console.WriteLine();
            }

        }
    }
}
