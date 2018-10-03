using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var priceApartment = 0.0;
            var priceStudio = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    priceApartment = nights * 65;
                    priceStudio = nights * 50 - (nights * 50 * 0.05);
                }
                else if (nights > 14)
                {
                    priceApartment = nights * 65 - (nights * 65 * 0.1);
                    priceStudio = nights * 50 - (nights * 50 * 0.3);
                }
                else
                {
                    priceApartment = nights * 65;
                    priceStudio = nights * 50;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceApartment = nights * 68.7 - (nights * 68.7 * 0.1);
                    priceStudio = nights * 75.2 - (nights * 75.2 * 0.2);
                }
                else
                {
                    priceApartment = nights * 68.7;
                    priceStudio = nights * 75.2;
                }
            }
            if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceApartment = nights * 77 - (nights * 77 * 0.1);
                    priceStudio = nights * 76;
                }
                else
                {
                    priceApartment = nights * 77;
                    priceStudio = nights * 76;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", priceApartment);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
    }
}
