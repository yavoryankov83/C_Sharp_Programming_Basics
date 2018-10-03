using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var countInGroup = int.Parse(Console.ReadLine());

            var VIP = 499.99;
            var Normal = 249.99;
            var moneyForTickets = 0.0;
            var moneyForTransport = 0.0;

            if (countInGroup >0 && countInGroup < 5)
            {
                moneyForTransport += budget * 0.75;
            }
            else if (countInGroup > 4 && countInGroup < 10)
            {
                moneyForTransport += budget * 0.6;
            }
            else if (countInGroup > 9 && countInGroup < 25)
            {
                moneyForTransport += budget * 0.5;
            }
            else if (countInGroup > 24 && countInGroup < 50)
            {
                moneyForTransport += budget * 0.4;
            }
            else
            {
                moneyForTransport += budget * 0.25;
            }
            moneyForTickets = budget - moneyForTransport;
            if (category == "Normal")
            {
                if (moneyForTickets >= Normal * countInGroup)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyForTickets - Normal * countInGroup);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Normal * countInGroup - moneyForTickets);
                }
            }
            else
            {
                if (moneyForTickets >= VIP * countInGroup)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyForTickets - VIP * countInGroup);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", VIP * countInGroup - moneyForTickets);
                }
            }
        }
    }
}
