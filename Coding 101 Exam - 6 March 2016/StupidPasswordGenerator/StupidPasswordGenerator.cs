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
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            int bigger;

            for (int i = 1; i < num1; i++)
            {
                for (int j = 1; j < num1; j++)
                {
                    for (char k = 'a'; k < num2 + 'a'; k++)
                    {
                        for (char l = 'a'; l < num2 + 'a'; l++)
                        {
                            if (j > i)
                            {
                                bigger = j;
                            }
                            else
                            {
                                bigger = i;
                            }
                            for (int m = bigger + 1; m <= num1; m++)
                            {
                                Console.Write($"{i}{j}{k}{l}{m} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
