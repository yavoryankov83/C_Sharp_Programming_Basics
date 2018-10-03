using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers
{
    class Increasing4Numbers
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                for (int j = a; j < b; j++)
                {
                    for (int k = a; k < b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            if (a <= i && i < j && j < k && k < l && l <= b)
                            {   
                                Console.WriteLine($"{i} {j} {k} {l}");
                            }
                        }
                    }
                }
            }
            if (b - a == 2)
            {
                Console.WriteLine("No");
            }
        }
    }
}
