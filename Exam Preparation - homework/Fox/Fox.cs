using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            //first part
            for (int row = 0; row < num; row++)
            {
                    Console.Write(new string('*', 1 + row));
                    Console.Write("\\");
                    Console.Write(new string('-', 2 * num - 1 - 2 * row));
                    Console.Write("/");
                    Console.WriteLine(new string('*', 1 + row));
            }
            //middle part
            for (int row = 0; row < num / 3; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', num / 2 + row));
                Console.Write("\\");
                Console.Write(new string('*', num - 2 * row));
                Console.Write("/");
                Console.Write(new string('*', num / 2 + row));
                Console.WriteLine("|");
            }

            //last part
            for (int row = 0; row < num; row++)
            {
                Console.Write(new string('-', 1 + row));
                Console.Write("\\");
                Console.Write(new string('*', 2 * num - 1 - 2 * row));
                Console.Write("/");
                Console.WriteLine(new string('-', 1 + row));
            }
        }
    }
}
