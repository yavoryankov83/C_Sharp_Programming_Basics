using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var missed = char.Parse(Console.ReadLine());

            var count = 0;

            for (char i = first; i <= second; i++)
            {
                for (char j = first ; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (!(i == missed || j == missed || k == missed))
                        {
                            Console.Write($"{i}{j}{k} ");
                            count++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
