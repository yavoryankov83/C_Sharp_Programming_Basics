using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDevisor
{
    class GreatestCommonDevisor
    {
        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine(GCD(a, b));
        }
    }
}
