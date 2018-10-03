using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //first row
            Console.Write("+ ");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();

            //middle
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("| ");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
                //Console.WriteLine("| " + new string('-', n - 2) + "|");
            }
            //last row
            Console.Write("+ ");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();

            //Console.WriteLine("+ " + new string('-', n - 2) + "+");
        }
    }
}
