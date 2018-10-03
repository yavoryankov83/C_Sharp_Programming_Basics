using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalNumbers
{
    class MythicalNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double result = 0.0;
            int lastDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int firstDigit = number / 100;

            if (lastDigit == 0)
            {
                result = secondDigit * firstDigit;
            }
            else if ( 0 < lastDigit && lastDigit <= 5)
            {
                result = (secondDigit * firstDigit) / (double)lastDigit;
            }
            else if (lastDigit > 5)
            {
                result = (secondDigit + firstDigit) * lastDigit;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
