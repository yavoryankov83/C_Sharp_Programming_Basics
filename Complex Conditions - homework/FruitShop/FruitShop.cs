using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            var cost = 0.0;

            bool realFruit = fruit == "banana" || fruit == "apple" || fruit == "orange"
                || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";

            bool workDay = day == "Monday" || day == "Tuesday" || day == "Wednesday"
                || day == "Thursday" || day == "Friday";

            bool relaxDay = day == "Saturday" || day == "Sunday";

            if (realFruit == false)
            {
                Console.WriteLine("error");
                return;
            }
            if (workDay == false && relaxDay == false)
            {
                Console.WriteLine("error");
                return;
            }
            if (fruit == "banana")
            {
                if (workDay)
                {
                    cost = quantity * 2.5;
                }
                else
                {
                    cost = quantity * 2.7;
                }
            }
            else if (fruit == "apple")
            {
                if (workDay)
                {
                    cost = quantity * 1.2;
                }
                else
                {
                    cost = quantity * 1.25;
                }
            }
            else if (fruit == "orange")
            {
                if (workDay)
                {
                    cost = quantity * 0.85;
                }
                else
                {
                    cost = quantity * 0.9;
                }
            }
            else if (fruit == "grapefruit")
            {
                if (workDay)
                {
                    cost = quantity * 1.45;
                }
                else
                {
                    cost = quantity * 1.6;
                }
            }
            else if (fruit == "kiwi")
            {
                if (workDay)
                {
                    cost = quantity * 2.7;
                }
                else
                {
                    cost = quantity * 3;
                }
            }
            else if (fruit == "pineapple")
            {
                if (workDay)
                {
                    cost = quantity * 5.5;
                }
                else
                {
                    cost = quantity * 5.6;
                }
            }
            else if (fruit == "grapes")
            {
                if (workDay)
                {
                    cost = quantity * 3.85;
                }
                else
                {
                    cost = quantity * 4.2;
                }
            }
            Console.WriteLine("{0:f2}", cost);
        }
    }
}
