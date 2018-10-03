using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            for (int n = 1; n <= 9; n++)
                            {
                                for (int m = 1; m <= 9; m++)
                                {
                                    if (i * j * k * l * n * m == num)
                                    {
                                        Console.Write($"{i}{j}{k}{l}{n}{m} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
