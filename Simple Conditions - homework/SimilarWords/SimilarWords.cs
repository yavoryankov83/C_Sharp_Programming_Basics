using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarWords
{
    class SimilarWords
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine().ToLower();
            var secondWord = Console.ReadLine().ToLower();

            Console.WriteLine(firstWord == secondWord ? "yes" : "no");
        }
    }
}
