using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var price = 0.0;

            if (season == "summer")
            {
                if (money <= 100)
                {
                    price = money * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", price);
                }
                else if (money > 100 && money <= 1000)
                {
                    price = money * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", price);
                }
                else if (money > 1000)
                {
                    price = money * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", price);
                }
            }
            if (season == "winter")
            {
                if (money <= 100)
                {
                    price = money * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", price);
                }
                else if (money > 100 && money <= 1000)
                {
                    price = money * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", price);
                }
                else if (money > 1000)
                {
                    price = money * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", price);
                }
            }
        }
    }
}
