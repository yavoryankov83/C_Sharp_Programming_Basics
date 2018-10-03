using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            long factorial = 1;
            double sum = 1 + 1 / x;

            for (int number = 2; number <= N; number++)
            {
                factorial *= number;
                double pow = Math.Pow(x, number);
                sum += factorial / pow;
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
