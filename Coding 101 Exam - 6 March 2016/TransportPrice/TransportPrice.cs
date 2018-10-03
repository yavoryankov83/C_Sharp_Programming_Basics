using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var kilometres = int.Parse(Console.ReadLine());
            var period = Console.ReadLine();
            var minPrice = double.MaxValue;

            if (kilometres < 20)
            {
                var taksiPrice = 0.7;
                if (period == "day")
                {
                    taksiPrice += kilometres * 0.79;
                }
                else
                {
                    taksiPrice += kilometres * 0.9;
                }
                minPrice = taksiPrice;
            }
            else if (kilometres >= 20 && kilometres < 100)
            {
                var busPrice = kilometres * 0.09;
                var taksiPrice = 0.7;
                if (period == "day")
                {
                    taksiPrice += kilometres * 0.79;
                }
                else
                {
                    taksiPrice += kilometres * 0.9;
                }
                minPrice = taksiPrice;
                if (busPrice < taksiPrice)
                {
                    minPrice = busPrice;
                }
            }
            else if (kilometres >= 100)
            {
                var trainPrice = kilometres * 0.06;
                var taksiPrice = 0.7;
                if (period == "day")
                {
                    taksiPrice += kilometres * 0.79;
                }
                else
                {
                    taksiPrice += kilometres * 0.9;
                }
                minPrice = taksiPrice;
                if (trainPrice < taksiPrice)
                {
                    minPrice = trainPrice;
                }
            }
            Console.WriteLine(minPrice);
        }
    }
}
