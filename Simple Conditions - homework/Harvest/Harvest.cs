using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var litresWine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var harvestGrape = (area * grape) * 0.4;
            var harvestWine = harvestGrape / 2.5;

            if (harvestWine >= litresWine)
            {
                var reminder = harvestWine - litresWine;
                var reminderPerWorker = reminder / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(harvestWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(reminder), Math.Ceiling(reminderPerWorker));
            }
            else
            {
                var neededWine = litresWine - harvestWine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededWine));
            }
        }
    }
}
