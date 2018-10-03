using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequense2K
{
    class Sequense2K
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
