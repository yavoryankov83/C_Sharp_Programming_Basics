using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Shop
    {
        static void Main(string[] args)
        {
            
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            var cost = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    cost = quantity * 0.5;
                }
                else if (product == "water")
                {
                    cost = quantity * 0.8;
                }
                else if (product == "beer")
                {
                    cost = quantity * 1.2;
                }
                else if (product == "sweets")
                {
                    cost = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    cost = quantity * 1.6;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    cost = quantity * 0.4;
                }
                else if (product == "water")
                {
                    cost = quantity * 0.7;
                }
                else if (product == "beer")
                {
                    cost = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    cost = quantity * 1.30;
                }
                else if (product == "peanuts")
                {
                    cost = quantity * 1.5;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    cost = quantity * 0.45;
                }
                else if (product == "water")
                {
                    cost = quantity * 0.7;
                }
                else if (product == "beer")
                {
                    cost = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    cost = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    cost = quantity * 1.55;
                }
            }
            Console.WriteLine(cost);
        }
    }
}
