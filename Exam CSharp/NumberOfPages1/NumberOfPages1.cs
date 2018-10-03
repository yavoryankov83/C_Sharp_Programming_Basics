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
            int pages = int.Parse(Console.ReadLine());
            int digits = 0;

            for (int i = 1; i <= pages; i++)
            {
                int currentPage = i;
                while (currentPage > 0)
                {
                    digits++;
                    currentPage /= 10;
                }
            }
            Console.WriteLine(digits);
        }
    }
}
