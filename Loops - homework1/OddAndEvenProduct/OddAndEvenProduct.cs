using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());
            ulong[] input = new ulong[N];
            input = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();

            ulong oddProduct = 1;
            ulong evenProduct = 1;


            for (int i = 0; i < input.Length; i +=2)
            {
                oddProduct *= input[i];
            }
            for (int i = 1; i < input.Length; i +=2)
            {
                evenProduct *= input[i];
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}
