using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int counter = 1;
            int maxcounter = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (1 <= N && N <= 1024)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (array[j + 1] == array[j])
                    {
                        counter++;
                        if (counter > maxcounter)
                        {
                            maxcounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                Console.WriteLine(maxcounter);
            }
        }
    }
}
