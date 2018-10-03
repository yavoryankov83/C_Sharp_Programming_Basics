using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumChars
{
    class SumChars
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();
            int sumOfVowelChars = 0;
            foreach (char item in name)
            {
                switch (item)
                {
                    case 'a':
                        sumOfVowelChars += 1;
                        break;
                    case 'e':
                        sumOfVowelChars += 2;
                        break;
                    case 'i':
                        sumOfVowelChars += 3;
                        break;
                    case 'o':
                        sumOfVowelChars += 4;
                        break;
                    case 'u':
                        sumOfVowelChars += 5;
                        break;
                }
            }
            Console.WriteLine(sumOfVowelChars);
        }
    }
}
