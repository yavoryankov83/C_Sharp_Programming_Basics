using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //1. read from the console
            string strNumber = Convert.ToString(number); //2. convert int to string to use digits easy
            Sum(strNumber); //7. call the method
            ReversedNumber(strNumber); //8. call the method

            string exchangedLasWithFirst = strNumber[3] + "" + strNumber[0] + strNumber[1] + strNumber[2];
            Console.WriteLine(exchangedLasWithFirst); //3. take the index ot digits in the string and change them

            string exchangedSecondWithThird = strNumber[0] + "" + strNumber[2] + strNumber[1] + strNumber[3];
            Console.WriteLine(exchangedSecondWithThird); //4. take the index ot digits in the string and change them




            //int number = int.Parse(Console.ReadLine()); //1. read rom the console
            //int firstDigit = number % 10; //2. take the fourth first from right to left
            //int secondDigit = (number / 10) % 10; //3. take the second digit from right to left
            //int thirdDigit = (number / 100) % 10; //4. take the third digit from right to left
            //int fourth = (number / 1000) % 10; //5. take the fourth digit from right to left
            //int sum = firstDigit + secondDigit + thirdDigit + fourth; //6. declare and find variable sum

            //Console.WriteLine(sum); //print sum
            //Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourth); //print
            //Console.WriteLine("{0}{1}{2}{3}", firstDigit, fourth, thirdDigit, secondDigit); //print
            //Console.WriteLine("{0}{1}{2}{3}", fourth, secondDigit, thirdDigit, firstDigit); //print
        }
        static void Sum(string strNumber) //5. make a method witch gather the digits
        {
            int result = 0;

            for (int i = 0; i < strNumber.Length; i++) //take the digits from left to right
            {
                result += strNumber[i] - 48;
            }
            Console.WriteLine(result);
        }
        static void ReversedNumber(string strNumber) //6. make a method witch reverses the digits
        {
            for (int i = strNumber.Length - 1; i >= 0; i--) //take the digits from right to left
            {
                Console.Write(strNumber[i]);
            }
            Console.WriteLine();
        }
    }
}
