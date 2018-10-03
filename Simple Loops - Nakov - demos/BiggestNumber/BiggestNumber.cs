using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                //biggestNumber = Math.Max(number, biggestNumber);
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
