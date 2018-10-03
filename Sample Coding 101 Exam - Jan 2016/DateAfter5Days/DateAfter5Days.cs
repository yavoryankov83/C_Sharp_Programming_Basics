using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            var daysCount = 0;
            var days = day + 5;

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysCount = 30;
            }
            else if (month == 2)
            {
                daysCount = 28;
            }
            else
            {
                daysCount = 31;
            }

            if (days > daysCount)
            {
                days = days - daysCount;
                if (month < 12)
                {
                    month += 1;
                }
                else
                {
                    month = month + 1 - 12;
                }
            }
            var after5Days = $"{days}.{month.ToString("00")}";
            Console.WriteLine(after5Days);
        }
    }
}
