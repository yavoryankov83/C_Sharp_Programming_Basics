using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumbers
{
    class FibonachiNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num1 = 0;
            var num2 = 1;
            var sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            Console.WriteLine(sum);
        }
    }
}
