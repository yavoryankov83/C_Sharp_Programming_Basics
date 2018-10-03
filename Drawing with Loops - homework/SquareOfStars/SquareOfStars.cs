using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var stars = int.Parse(Console.ReadLine());

            for (int i = 0; i < stars; i++)
            {
                Console.Write('*');

                for (int j = 0; j < stars - 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
