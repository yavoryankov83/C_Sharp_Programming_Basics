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
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (nightsCount > 7 && nightsCount < 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
                else if (nightsCount > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.3;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (nightsCount > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.2;
                }
            }
            else
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }
            if (nightsCount > 14)
            {
                apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice * nightsCount);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nightsCount);
        }
    }
}
