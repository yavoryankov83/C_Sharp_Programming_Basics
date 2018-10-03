using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row
            Console.WriteLine(new string(' ', n + 1) + "|");

            //left side
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write(new string('*', row));
                Console.Write(" |");

                //right side
                Console.Write(" ");

                for (int i = 1; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
