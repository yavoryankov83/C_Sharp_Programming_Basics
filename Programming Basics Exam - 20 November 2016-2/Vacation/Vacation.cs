using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var oldPeople = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var priceOlds = 0.0;
            var priceStuds = 0.0;
            var priceNights = nights * 82.99;
            var sum = 0.0;

            if (transport == "train")
            {
                priceOlds = 24.99 * oldPeople;
                priceStuds = 14.99 * students;

                if (oldPeople + students >= 50)
                {
                    priceOlds = priceOlds - priceOlds * 0.5;
                    priceStuds = priceStuds - priceStuds * 0.5;
                }
            }
            else if (transport == "bus")
            {
                priceOlds = 32.50 * oldPeople;
                priceStuds = 28.50 * students;
            }
            else if (transport == "boat")
            {
                priceOlds = 42.99 * oldPeople;
                priceStuds = 39.99 * students;
            }
            else
            {
                priceOlds = 70 * oldPeople;
                priceStuds = 50 * students;
            }

            sum = priceNights + 2 * (priceOlds + priceStuds);
            var finalSum = sum + sum * 0.1;
            Console.WriteLine("{0:f2}", finalSum);
        }
    }
}
