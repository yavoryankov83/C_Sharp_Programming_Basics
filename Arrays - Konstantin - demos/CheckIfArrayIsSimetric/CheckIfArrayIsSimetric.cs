using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfArrayIsSimetric
{
    class CheckIfArrayIsSimetric
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 4, 3, 4};
            bool isSimeric = true;

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    isSimeric = false;
                    break;
                }
            }
            Console.WriteLine(isSimeric ? "Simetric" : "Is not Simetric");
        }
    }
}
