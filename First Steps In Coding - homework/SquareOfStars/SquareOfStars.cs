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
            int positiveNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', positiveNumber));

            for (int i = 0; i < positiveNumber - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', positiveNumber - 2) + "*");
            }

            Console.WriteLine(new string('*', positiveNumber));
        }
    }
}
