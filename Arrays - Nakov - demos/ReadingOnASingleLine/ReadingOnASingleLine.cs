using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingOnASingleLine
{
    class ReadingOnASingleLine
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '.', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                
            }
            Console.WriteLine(string.Join(":", array));
        }

    }
}
