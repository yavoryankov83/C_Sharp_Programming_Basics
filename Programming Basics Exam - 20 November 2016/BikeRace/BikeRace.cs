using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            var juniorsCount = int.Parse(Console.ReadLine());
            var seniorsCount = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();

            var profit = 0.0;

            if (trace == "trail")
            {
                profit = 5.5 * juniorsCount + 7 * seniorsCount;
            }
            else if (trace == "downhill")
            {
                profit = 12.25 * juniorsCount + 13.75 * seniorsCount;
            }
            else if (trace == "road")
            {
                profit = 20 * juniorsCount + 21.50 * seniorsCount;
            }
            else
            {
                profit = 8 * juniorsCount + 9.50 * seniorsCount;
                if (juniorsCount + seniorsCount >= 50)
                {
                    profit = profit - profit * 0.25;
                }
            }
            Console.WriteLine("{0:f2}", profit - profit * 0.05);
        }
    }
}
