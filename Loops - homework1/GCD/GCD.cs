using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int index = input.IndexOf(' ');
            int a = index;
            int b = input.Length - index - 1;
            int firstInteger = Convert.ToInt32(input.Substring(0, index));
            int secodInteger = Convert.ToInt32(input.Substring(a + 1, b));

            if (secodInteger > firstInteger)
            {
                int temp = firstInteger;
                firstInteger = secodInteger;
                secodInteger = temp;
            }
            while (firstInteger % secodInteger != 0)
            {
                int temp = (firstInteger % secodInteger);
                firstInteger = secodInteger;
                secodInteger = temp;
            }
            Console.WriteLine(secodInteger);
        }
    }
}
