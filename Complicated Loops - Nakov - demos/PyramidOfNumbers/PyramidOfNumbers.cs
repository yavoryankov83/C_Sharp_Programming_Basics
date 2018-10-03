using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers
{
    class PyramidOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col > 1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(num);
                    num++;
                   
                    if (num > n)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
