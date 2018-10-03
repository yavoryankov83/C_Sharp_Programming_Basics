using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long P = long.Parse(Console.ReadLine()); //1. read from the console given number
            int N = int.Parse(Console.ReadLine()); //2. read from the console index of bit

            if (0 <= P && P <= Math.Pow(2, 55) && 0 < N && N < 55)
            {
                int PMask = 1 << N;
                long PAndMask = P & PMask;
                long bit = (P & PMask) >> N;
                Console.WriteLine(bit);
            }
            //Console.WriteLine((P >> N) & 1); //3. use the formula ((number >> index) & 1) and print
            
        }
    }
}
