using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceOfTransport
{
    class PriceOfTransport
    {
        static void Main(string[] args)
        {
            var kilometers = int.Parse(Console.ReadLine());
            var period = Console.ReadLine();

            double minPrice = double.MaxValue;

            double taksiDay = 0.7 + 0.79 * kilometers;
            double taksiNight = 0.7 + 0.9 * kilometers;

            double bus = 0.09 * kilometers; //min 20 kilometers

            double train = 0.06 * kilometers; // min 100 kilometers

            if (kilometers < 20 && period == "day")
            {
                minPrice = taksiDay;
            }
            else if (kilometers < 20 && period == "night")
            {
                minPrice = taksiNight;
            }
            if (kilometers >= 100 && period == "day")
            {
                minPrice = train;
                if (train > Math.Min(taksiDay, bus))
                {
                    minPrice = Math.Min(taksiDay, bus);
                }
            }
            else if (kilometers >= 100 && period == "night")
            {
                minPrice = train;
                if (train > Math.Min(taksiNight, bus))
                {
                    minPrice = Math.Min(taksiNight, bus);
                }
            }
            if (kilometers >= 20 && kilometers < 100 && period == "day")
            {
                minPrice = bus;
                if (bus > taksiDay)
                {
                    minPrice = taksiDay;
                }
            }
            else if (kilometers >= 20 && kilometers < 100 && period == "night")
            {
                minPrice = bus;
                if (bus > taksiNight)
                {
                    minPrice = taksiNight;
                }
            }
            Console.WriteLine(minPrice);
        }
    }
}
