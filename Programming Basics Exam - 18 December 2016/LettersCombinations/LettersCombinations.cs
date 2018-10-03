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
            var startLetter = char.Parse(Console.ReadLine());
            var endLetter = char.Parse(Console.ReadLine());
            var skipLetter = char.Parse(Console.ReadLine());

            var count = 0;

            for (char first = startLetter; first <= endLetter; first++)
            {
                for (char second = startLetter; second <= endLetter; second++)
                {
                    for (char third = startLetter; third <= endLetter; third++)
                    {
                        if (!(third == skipLetter || second == skipLetter || first == skipLetter))
                        {
                            Console.Write($"{first}{second}{third} ");
                            count++;
                        }   
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
