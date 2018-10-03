using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPages
{
    class NumberOfPages
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int pages = 0;
            int currentDigits = 0;

            for (int page = 1; currentDigits < digit; page++)
            {
                pages++;
                currentDigits += page.ToString().Length;
            }
            Console.WriteLine(pages);
        }
    }
}
