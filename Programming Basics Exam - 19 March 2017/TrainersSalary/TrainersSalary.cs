using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            var lections = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var budgetPerLection = budget / lections;
            var count1 = 0;
            var count2 = 0;
            var count3 = 0;
            var count4 = 0;
            var count5 = 0;
            var count6 = 0;

            for (int i = 0; i < lections; i++)
            {
                var lectorName = Console.ReadLine();

                if (lectorName == "Jelev")
                {
                    count1++;
                }
                else if (lectorName == "RoYaL")
                {
                    count2++;
                }
                else if (lectorName == "Roli")
                {
                    count3++;
                }
                else if (lectorName == "Trofon")
                {
                    count4++;
                }
                else if (lectorName == "Sino")
                {
                    count5++;
                }
                else
                {
                    count6++;
                }
            }
            Console.WriteLine($"Jelev salary: {(count1 * budgetPerLection).ToString("0.00")} lv");
            Console.WriteLine($"RoYaL salary: {(count2 * budgetPerLection).ToString("0.00")} lv");
            Console.WriteLine($"Roli salary: {(count3 * budgetPerLection).ToString("0.00")} lv");
            Console.WriteLine($"Trofon salary: {(count4 * budgetPerLection).ToString("0.00")} lv");
            Console.WriteLine($"Sino salary: {(count5 * budgetPerLection).ToString("0.00")} lv");
            Console.WriteLine($"Others salary: {(count6 * budgetPerLection).ToString("0.00")} lv");
        }
    }
}
