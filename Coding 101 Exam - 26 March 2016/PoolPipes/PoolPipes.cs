using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hoursWithoutWorker = double.Parse(Console.ReadLine());

            var pipe1V = pipe1 * hoursWithoutWorker;
            var pipe2V = pipe2 * hoursWithoutWorker;
            var pipeV = pipe1V + pipe2V;
            var full = (pipeV / V) * 100;
            var fullPipe1 = (pipe1V / pipeV) * 100;
            var fullPipe2 = (pipe2V / pipeV) * 100;

            if (V >= pipeV)
            {
                Console.WriteLine($"The pool is {Math.Truncate(full)}% full. Pipe 1: {Math.Truncate(fullPipe1)}%. Pipe 2: {Math.Truncate(fullPipe2)}%.");
            }
            else
            {
                var diff = pipeV - V;
                Console.WriteLine($"For {hoursWithoutWorker} hours the pool overflows with {diff} liters.");
            }
        }
    }
}
