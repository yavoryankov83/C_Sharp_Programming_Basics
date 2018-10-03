using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mode2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char[] firstArray = str1.ToArray();
            string str2 = Console.ReadLine();
            char[] secondArray = str2.ToArray();
            bool checkEqual = true;
            bool? checkArr1smaller = null;

            if (1 <= firstArray.Length && firstArray.Length <= 128 && 1 <= secondArray.Length && secondArray.Length <= 128)
            {
                for (int i = 0; i < (Math.Min(firstArray.Length, secondArray.Length)); i++)
                {
                    checkEqual = (firstArray[i] == secondArray[i]);
                    if (checkEqual == false)
                    {
                        checkArr1smaller = firstArray[i] < secondArray[i] ? true : false;
                        goto next1;
                    }
                }
                next1:
                if (checkEqual == true && firstArray.Length != secondArray.Length)
                {
                    checkEqual = false;
                    checkArr1smaller = firstArray.Length < secondArray.Length ? true : false;
                }
                Console.WriteLine(checkEqual == true ? "=" : (checkArr1smaller == true ? "<" : ">"));
            }
        }
    }
}
