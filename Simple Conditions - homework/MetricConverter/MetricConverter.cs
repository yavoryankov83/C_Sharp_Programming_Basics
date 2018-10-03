using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var number = decimal.Parse(Console.ReadLine());
            var toConvert = Console.ReadLine().ToLower();
            var converted = Console.ReadLine().ToLower();

            var first = 0.0m;
            var second = 0.0m;

            if (toConvert == "m")
            {
                first = 1;
            }
            else if (toConvert == "mm")
            {
                first = 1000m;
            }
            else if (toConvert == "cm")
            {
                first = 100m;
            }
            else if (toConvert == "mi")
            {
                first = 0.000621371192m;
            }
            else if (toConvert == "in")
            {
                first = 39.3700787m;
            }
            else if (toConvert == "km")
            {
                first = 0.001m;
            }
            else if (toConvert == "ft")
            {
                first = 3.2808399m;
            }
            else if (toConvert == "yd")
            {
                first = 1.0936133m;
            }
            if (converted == "m")
            {
                second = 1;
            }
            else if (converted == "mm")
            {
                second = 1000m;
            }
            else if (converted == "cm")
            {
                second = 100m;
            }
            else if (converted == "mi")
            {
                second = 0.000621371192m;
            }
            else if (converted == "in")
            {
                second = 39.3700787m;
            }
            else if (converted == "km")
            {
                second = 0.001m;
            }
            else if (converted == "ft")
            {
                second = 3.2808399m;
            }
            else if (converted == "yd")
            {
                second = 1.0936133m;
            }

            decimal result = number * (second / first);

            Console.WriteLine($"{result} {converted}");
        }
    }
}
