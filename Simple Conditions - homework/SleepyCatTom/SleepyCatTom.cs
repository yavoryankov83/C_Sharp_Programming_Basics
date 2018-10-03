using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom
{
    class SleepyCatTom
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());

            var holidayPlayTime = holidays * 127;
            var workingPlayTime = (365 - holidays) * 63;
            var playTimePerYear = holidayPlayTime + workingPlayTime;

            if (playTimePerYear <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                var diff = 30000 - playTimePerYear;
                Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                var diff = playTimePerYear - 30000;
                Console.WriteLine("{0} hours and {1} minutes more for play", diff / 60, diff % 60);
            }
        }
    }
}
