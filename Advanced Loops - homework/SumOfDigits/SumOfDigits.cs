using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine()).ToString();

            int result = 0;

            foreach (char digit in num)
            {
                result += digit - '0';
            }
            Console.WriteLine(result);
        }
    }
}
