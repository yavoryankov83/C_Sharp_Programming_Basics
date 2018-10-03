using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());

            int store = 0;

            if (1 <= N && N <=1024)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == X)
                    {
                        store = i;
                        Console.WriteLine(store);
                        break;
                    }
                    if (array[i] != X && i == array.Length - 1)
                    {
                        Console.WriteLine("-1");
                    }
                }
            }
        }
    }
}
