using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombinations
{
    class MagicCombinations
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            for (int m = 0; m <= 9; m++)
                            {
                                for (int n = 0; n <= 9; n++)
                                {
                                    if (num == i * j * k * l * m * n)
                                    {
                                        Console.Write($"{i}{j}{k}{l}{m}{n} ");
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
