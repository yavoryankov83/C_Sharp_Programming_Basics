using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Ticket
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var fens = int.Parse(Console.ReadLine());

            var budgetForTickets = 0.0m;
            var sum = 0.0m;
            var diff = 0.0m;

            if (fens >= 1 && fens <= 4)
            {
                budgetForTickets = budget - budget * 0.75m;
                if (category == "Normal")
                {
                    sum = fens * 249.99m;
                    if (sum <= budgetForTickets)
                    {
                        diff = Math.Abs(budgetForTickets - sum);
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
                else
                {
                    sum = fens * 499.99m;
                    diff = Math.Abs(budgetForTickets - sum);
                    if (sum <= budgetForTickets)
                    {   
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
            }
            else if (fens >= 5 && fens <= 9)
            {
                budgetForTickets = budget - budget * 0.6m;
                if (category == "Normal")
                {
                    sum = fens * 249.99m;
                    if (sum <= budgetForTickets)
                    {
                        diff = Math.Abs(budgetForTickets - sum);
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
                else
                {
                    sum = fens * 499.99m;
                    diff = Math.Abs(budgetForTickets - sum);
                    if (sum <= budgetForTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
            }
            else if (fens >= 10 && fens <= 24)
            {
                budgetForTickets = budget - budget * 0.5m;
                if (category == "Normal")
                {
                    sum = fens * 249.99m;
                    if (sum <= budgetForTickets)
                    {
                        diff = Math.Abs(budgetForTickets - sum);
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
                else
                {
                    sum = fens * 499.99m;
                    diff = Math.Abs(budgetForTickets - sum);
                    if (sum <= budgetForTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
            }
            if (fens >= 25 && fens <= 49)
            {
                budgetForTickets = budget - budget * 0.4m;
                if (category == "Normal")
                {
                    sum = fens * 249.99m;
                    if (sum <= budgetForTickets)
                    {
                        diff = Math.Abs(budgetForTickets - sum);
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
                else
                {
                    sum = fens * 499.99m;
                    diff = Math.Abs(budgetForTickets - sum);
                    if (sum <= budgetForTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
            }
            else if (fens >= 50)
            {
                budgetForTickets = budget - budget * 0.25m;
                if (category == "Normal")
                {
                    sum = fens * 249.99m;
                    if (sum <= budgetForTickets)
                    {
                        diff = Math.Abs(budgetForTickets - sum);
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
                else
                {
                    sum = fens * 499.99m;
                    diff = Math.Abs(budgetForTickets - sum);
                    if (sum <= budgetForTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", diff);
                    }
                }
            }

        }
    }
}
