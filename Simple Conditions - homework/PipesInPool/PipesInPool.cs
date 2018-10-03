using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var pipe1Volume = pipe1 * hours;
            var pipe2Volume = pipe2 * hours;

            var pipeVolume = pipe1Volume + pipe2Volume;

            var fullInPercents = (pipeVolume / volume) * 100;
            var fullPipe1 = (pipe1Volume / pipeVolume) * 100;
            var fullPipe2 = (pipe2Volume / pipeVolume) * 100;

            if (pipeVolume <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(fullInPercents), Math.Truncate(fullPipe1), Math.Truncate(fullPipe2));

            }
            else
            {
                var diff = pipeVolume - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, diff);
            }
        }
    }
}
