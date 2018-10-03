using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k < l + 'a'; k++)
                    {
                        for (char p = 'a'; p < l + 'a'; p++)
                        {
                            int max;
                            if (j > i)
                            {
                                max = j;
                            }
                            else
                            {
                                max = i;
                            }
                            for (int m = max + 1; m <= n; m++)
                            {
                                Console.Write($"{i}{j}{k}{p}{m} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
