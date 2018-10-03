using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write(new string('/', 2));
                Console.Write(new string('_', 2 * n - 1 + 2 * i));
                Console.Write(new string('\\', 2)); 
                Console.WriteLine(new string('.', n - i));
            }
            //next row
            Console.Write(new string('/', 2));
            Console.Write(new string('_', (4 * n - 6) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (4 * n - 6) / 2));
            Console.WriteLine(new string('\\', 2));
            //next row
            Console.Write(new string('\\', 2));
            Console.Write(new string('_', 4 * n - 1));
            Console.WriteLine(new string('/', 2));
            //last part
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', 1 + i));
                Console.Write(new string('\\', 2));
                Console.Write(new string('_', 4 * n - 3 - 2 * i));
                Console.Write(new string('/', 2));
                Console.WriteLine(new string('.', 1 + i));
            }
        }
    }
}
