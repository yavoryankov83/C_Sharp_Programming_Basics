using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            var firstPlayerCount = int.Parse(Console.ReadLine());
            var secondPlayerCount = int.Parse(Console.ReadLine());
            var maxBattlesCount = int.Parse(Console.ReadLine());

            var count = 0;

            for (int first = 1; first <= firstPlayerCount; first++)
            {
                for (int second = 1; second <= secondPlayerCount; second++)
                {
                    if (count == maxBattlesCount)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"({first} <-> {second}) ");
                    }
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
