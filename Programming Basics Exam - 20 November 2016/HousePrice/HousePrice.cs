using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var pricePerSquareMeter = double.Parse(Console.ReadLine());

            var bathroomArea = smallestRoomArea / 2;
            var secondRoomArea = smallestRoomArea + smallestRoomArea * 0.1;
            var thirdRoomArea = secondRoomArea + secondRoomArea * 0.1;
            var koridorArea = (smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea) * 0.05;
            var homeArea = smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea + koridorArea;

            Console.WriteLine("{0:f2}", homeArea * pricePerSquareMeter);
        }
    }
}
