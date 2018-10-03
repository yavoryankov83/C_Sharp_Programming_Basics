using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
