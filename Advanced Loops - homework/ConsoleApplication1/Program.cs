using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int c = 97;
            int d = 97;
            int bigger = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            if (i > j)
                            {
                                bigger = i + 1;
                            }
                            else
                            {
                                bigger = j + 1;
                            }
                            for (int o = bigger; o <= n; o++)
                            {
                                Console.Write("{0}{1}", i, j);
                                string simbol3 = Char.ConvertFromUtf32(c + k);
                                string simbol4 = Char.ConvertFromUtf32(d + m);
                                Console.Write("{0}{1}", simbol3, simbol4);
                                Console.Write("{0} ", o);
                            }
                        }
                    }
                }
            }
        }
    }
}
