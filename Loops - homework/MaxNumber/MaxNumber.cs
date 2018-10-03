using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
