using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kilemetersPerMonth = double.Parse(Console.ReadLine());

            var pricePerKilometer = 0.0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kilemetersPerMonth <= 5000)
                {
                    pricePerKilometer = 0.75;
                }
                else if (kilemetersPerMonth > 5000 && kilemetersPerMonth <= 10000)
                {
                    pricePerKilometer = 0.95;
                }
                else if (kilemetersPerMonth > 10000 && kilemetersPerMonth <= 20000)
                {
                    pricePerKilometer = 1.45;
                }
            }
            else if (season == "Summer")
            {
                if (kilemetersPerMonth <= 5000)
                {
                    pricePerKilometer = 0.90;
                }
                else if (kilemetersPerMonth > 5000 && kilemetersPerMonth <= 10000)
                {
                    pricePerKilometer = 1.10;
                }
                else if (kilemetersPerMonth > 10000 && kilemetersPerMonth <= 20000)
                {
                    pricePerKilometer = 1.45;
                }
            }
            else
            {
                if (kilemetersPerMonth <= 5000)
                {
                    pricePerKilometer = 1.05;
                }
                else if (kilemetersPerMonth > 5000 && kilemetersPerMonth <= 10000)
                {
                    pricePerKilometer = 1.25;
                }
                else if (kilemetersPerMonth > 10000 && kilemetersPerMonth <= 20000)
                {
                    pricePerKilometer = 1.45;
                }
            }

            var moneyEarned = kilemetersPerMonth * pricePerKilometer * 4;
            var taxes = moneyEarned * 0.1;
            var money = moneyEarned - taxes;

            Console.WriteLine("{0:f2}", money);
        }
    }
}
