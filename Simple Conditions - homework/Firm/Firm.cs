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
            var hoursNeeded = int.Parse(Console.ReadLine());
            var daysOnDemand = int.Parse(Console.ReadLine());
            var workresOnExtraTime = int.Parse(Console.ReadLine());

            var hours = Math.Truncate((daysOnDemand - daysOnDemand * 0.1) * 8);
            var extraHours = daysOnDemand * 2 * workresOnExtraTime;

            var allHours = hours + extraHours;
            var hoursLeft = Math.Abs(allHours - hoursNeeded);

            if (hoursNeeded <= allHours)
            {
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursLeft);
            }
        }
    }
}
