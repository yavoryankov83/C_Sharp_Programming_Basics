using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciNumbers
{
    class FibonaciNumbers
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int next = n1 + n2;
                n1 = n2;
                n2 = next;
            }
            Console.WriteLine(n2);
        }
    }
}
