using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] strWord = word.ToCharArray();
            char[] letters = new char[26];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('a' + i);
            }
            for (int j = 0; j < strWord.Length; j++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    if (strWord[j] == letters[k])
                    {
                        Console.WriteLine("{0}", k);
                    }
                }
            }
        }
    }
}
