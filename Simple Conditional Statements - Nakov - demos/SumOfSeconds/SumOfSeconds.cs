using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeconds
{
    class SumOfSeconds
    {
        static void Main(string[] args)
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());
            int sum = seconds1 + seconds2 + seconds3;

            if ((sum % 60) < 10)
            {
                Console.WriteLine("{0}:0{1}", (sum / 60), (sum % 60));
            }
            else
            {
                Console.WriteLine("{0}:{1}", (sum / 60), (sum % 60));
            }

        }
    }
}
