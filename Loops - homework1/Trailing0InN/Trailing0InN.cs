using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Trailing0InN
{
    class Trailing0InN
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int zerosInFactorial = 0;

            for (int i = 5; i <= number; i += 5)
            {
                int term = i;

                while ((term % 5) == 0)
                {
                    zerosInFactorial += 1;
                    term /= 5;
                    //long num = long.Parse(Console.ReadLine());
                    //BigInteger factorialN = 1;
                    //BigInteger count = 0;

                    //for (int i = 1; i <= num; i++)
                    //{
                    //    factorialN *= i;
                    //}
                    //BigInteger value = factorialN;
                    //string str = value.ToString();

                    //for (int j = str.Length - 1; j > 0; j--)
                    //{
                    //    if (str[j] == '0')
                    //    {
                    //        count++;
                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }
                    //}
                    //Console.WriteLine(count);
                }
            }
            Console.WriteLine(zerosInFactorial);
        }
    }
}
