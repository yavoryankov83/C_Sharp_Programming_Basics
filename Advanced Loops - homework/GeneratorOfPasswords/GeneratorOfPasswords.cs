using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorOfPasswords
{
    class GeneratorOfPasswords
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            int bigger;

            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (char c = 'a'; c < l + 'a'; c++)
                    {
                        for (char d = 'a'; d < l + 'a'; d++)
                        {
                            if (a > b)
                            {
                                bigger = a;
                            }
                            else
                            {
                                bigger = b;
                            }
                            for (int e = bigger + 1; e <= n; e++)
                            {
                                Console.Write("{0}{1}", a, b);
                                Console.Write("{0}", c);
                                Console.Write("{0}", d);
                                Console.Write("{0} ", e);
                            }
                        }
                    }
                }
            }
        }
    }
}
