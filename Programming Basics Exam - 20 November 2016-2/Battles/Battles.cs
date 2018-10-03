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
            var firstPlayerPokemonCount = int.Parse(Console.ReadLine());
            var secondPlayerPokemonCount = int.Parse(Console.ReadLine());
            var maxFights = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 1; i <= firstPlayerPokemonCount; i++)
            {
                for (int j = 1; j <= secondPlayerPokemonCount; j++)
                {
                    if (count >= maxFights)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {j}) ");
                    count++;
                }
            }
        }
    }
}
