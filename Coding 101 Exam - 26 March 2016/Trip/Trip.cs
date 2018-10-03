using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var budgetForNights = 0.0;
            var destination = "";
            var place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    budgetForNights = budget * 0.3;
                }
                else
                {
                    place = "Hotel";
                    budgetForNights = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    budgetForNights = budget * 0.4;
                }
                else
                {
                    place = "Hotel";
                    budgetForNights = budget * 0.8;
                }
            }
            else
            {
                place = "Hotel";
                destination = "Europe";
                budgetForNights = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {budgetForNights.ToString("0.00")}");
        }
    }
}
