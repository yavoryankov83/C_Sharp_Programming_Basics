using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var num1 = num;
            var thirdDigit = num1 % 10;
            num1 /= 10;
            var secondDigit = num1 % 10;
            var firstDigit = num1 /= 10;

            var rows = firstDigit + secondDigit;
            var cols = firstDigit + thirdDigit;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (num % 5 == 0)
                    {
                        num -= firstDigit;
                        Console.Write("{0} ", num);
                    }
                    else if (num % 3 == 0)
                    {
                        num -= secondDigit;
                        Console.Write("{0} ", num);
                    }
                    else
                    {
                        num += thirdDigit;
                        Console.Write("{0} ", num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
