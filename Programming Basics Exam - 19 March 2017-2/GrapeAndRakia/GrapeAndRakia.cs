using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            var grapeArea = double.Parse(Console.ReadLine());
            var grapeKilosPerMeter = double.Parse(Console.ReadLine());
            var extra = double.Parse(Console.ReadLine());

            var grapeEarned = grapeArea * grapeKilosPerMeter;
            var grape = grapeEarned - extra;

            var grapePrice = (grape * 0.55) * 1.5;
            var rakia = (grape * 0.45) / 7.5;
            var rakiaPrice = rakia * 9.8;

            Console.WriteLine("{0:f2}", rakiaPrice);
            Console.WriteLine("{0:f2}", grapePrice);
        }
    }
}
