using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var givenDays = int.Parse(Console.ReadLine());
            var extraWorkers = int.Parse(Console.ReadLine());

            var vocationDays = givenDays * 0.1;
            var workingDays = givenDays - vocationDays;
            double workingHours = workingDays * 8;
            var extraWorkingHours = extraWorkers * 2 * givenDays;
            var extraHours = workingHours + extraWorkingHours;
            var isFinished = extraHours >= neededHours;
            var diff = Math.Abs(Math.Floor(extraHours) - neededHours);

            Console.WriteLine(isFinished ? $"Yes!{diff} hours left." : $"Not enough time!{diff} hours needed.");
        }
    }
}
