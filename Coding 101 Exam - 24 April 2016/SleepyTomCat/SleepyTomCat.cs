using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            var freeDaysCount = int.Parse(Console.ReadLine());

            var playTimePerYear = 30000;
            var workHours = 63;
            var freeHours = 127;
            var workHoursPerYear = (365 - freeDaysCount) * workHours;
            var freeHoursPerYear = freeDaysCount * freeHours;
            var playTime = workHoursPerYear + freeHoursPerYear;
            var diff = Math.Abs(playTimePerYear - playTime);

            if (playTime > playTimePerYear)
            {
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diff / 60} hours and {diff % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diff / 60} hours and {diff % 60} minutes less for play");
            }
        }
    }
}
