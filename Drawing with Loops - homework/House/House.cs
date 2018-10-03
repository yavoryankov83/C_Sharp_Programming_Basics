using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var starsCount = 2;

            //roof
            if (n % 2 == 1)
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
                starsCount++;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n / 2 - 1 - i));
                Console.Write(new string('*', starsCount + 2 * i));
                Console.WriteLine(new string('-', n / 2 - 1 - i));
            }
        
            //fundament
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}
