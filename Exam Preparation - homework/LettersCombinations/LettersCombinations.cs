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
            var firstLetter = char.Parse(Console.ReadLine());
            var secondtLetter = char.Parse(Console.ReadLine());
            var letterToMiss = char.Parse(Console.ReadLine());

            var counter = 0;

            for (char i = firstLetter; i <= secondtLetter; i++)
            {
                for (char j = firstLetter; j <= secondtLetter; j++)
                {
                    for (char k = firstLetter; k <= secondtLetter; k++)
                    {
                        if (k == letterToMiss || j == letterToMiss || i == letterToMiss)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
