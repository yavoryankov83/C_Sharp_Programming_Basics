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
                Console.Write("//");
                Console.Write(new string('_', 2 * n - 1 + 2 * i));
                Console.Write("\\");
                Console.Write("\\");
                Console.WriteLine(new string('.', n - i));
            }

            //second row
            Console.Write("//");;
            Console.Write(new string('_', (4 * n - 6) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (4 * n - 6) / 2));
            Console.Write("\\");
            Console.WriteLine("\\");

            //last part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', 0 + i));
                Console.Write("\\");
                Console.Write("\\");
                Console.Write(new string('_', 4 * n - 1 - 2 * i));
                Console.Write("//");
                Console.WriteLine(new string('.', 0 + i));
            }
        }
    }
}
