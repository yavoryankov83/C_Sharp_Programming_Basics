using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFrom0To100WithText
{
    class NumberFrom0To100WithText
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var y = 0;

            var result = "";

            string[] text1 = "zero, one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen".Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] text2 = "twenty, thirty, fourty, fifty, sixty, seventy, eighty, ninety".Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
                return;

            }
            if (number >= 0 && number < 20)
            {
                for (int i = 0; i < text1.Length; i++)
                {
                    if (number == i)
                    {
                        result = text1[i];
                    }
                }
            }
            else if (number == 20)
            {
                result = text2[0];
            }
            else if (number == 30)
            {
                result = text2[1];
            }
            else if (number == 40)
            {
                result = text2[2];
            }
            else if (number == 50)
            {
                result = text2[3];
            }
            else if (number == 60)
            {
                result = text2[4];
            }
            else if (number == 70)
            {
                result = text2[5];
            }
            else if (number == 80)
            {
                result = text2[6];
            }
            else if (number == 90)
            {
                result = text2[7];
            }
            else if (number == 100)
            {
                result = "one hundred";
            }
            else
            {
                while (y != number)
                {
                    y++;
                }
                if (number > 20 && number < 30)
                {
                    result = text2[0] + " " + text1[y - 20];
                }
                if (number > 30 && number < 40)
                {
                    result = text2[1] + " " + text1[y - 30];
                }
                if (number > 40 && number < 50)
                {
                    result = text2[2] + " " + text1[y - 40];
                }
                if (number > 50 && number < 60)
                {
                    result = text2[3] + " " + text1[y - 50];
                }
                if (number > 60 && number < 70)
                {
                    result = text2[4] + " " + text1[y - 60];
                }
                if (number > 70 && number < 80)
                {
                    result = text2[5] + " " + text1[y - 70];
                }
                if (number > 80 && number < 90)
                {
                    result = text2[6] + " " + text1[y - 80];
                }
                if (number > 90 && number < 100)
                {
                    result = text2[7] + " " + text1[y - 90];
                }
            }
            Console.WriteLine(result);
        }
    }
}