using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var loadCount = int.Parse(Console.ReadLine());

            var price = 0;
            var weightCount = 0.0;
            var weightCountByMicrobus = 0;
            var weightCountByTruck = 0;
            var weightCountByTrain = 0;

            for (int i = 0; i < loadCount; i++)
            {
                var loadWeight = int.Parse(Console.ReadLine());

                weightCount += loadWeight;

                if (loadWeight <= 3)
                {
                    price += loadWeight * 200;
                    weightCountByMicrobus += loadWeight;
                }
                else if (loadWeight >= 4 && loadWeight <= 11)
                {
                    price += loadWeight * 175;
                    weightCountByTruck += loadWeight;
                }
                else
                {
                    price += loadWeight * 120;
                    weightCountByTrain += loadWeight;
                }
            }
            Console.WriteLine("{0:f2}", price / weightCount);
            //Console.WriteLine("{0:f2}%", (weightCountByMicrobus / weightCount) * 100);
            Console.WriteLine((weightCountByMicrobus / weightCount).ToString("0.00%"));
            Console.WriteLine("{0:f2}%", (weightCountByTruck / weightCount) * 100);
            Console.WriteLine("{0:f2}%", (weightCountByTrain / weightCount) * 100);
        }
    }
}
