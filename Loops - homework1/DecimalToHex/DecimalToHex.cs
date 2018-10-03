using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string hex = String.Empty;
            string convert = " ";

            if (number == 0)
            {
                hex = "0";
            }

            while (number > 0)
            {
                if (number % 16 > 9)
                {
                    if (number % 16 == 10)
                    {
                        convert += "A";
                    }
                    if (number % 16 == 11)
                    {
                        convert += "B";
                    }
                    if (number % 16 == 12)
                    {
                        convert += "C";
                    }
                    if (number % 16 == 13)
                    {
                        convert += "D";
                    }
                    if (number % 16 == 14)
                    {
                        convert += "E";
                    }
                    if (number % 16 == 15)
                    {
                        convert += "F";
                    }
                }
                else
                {
                    convert += number % 16;
                }
                number /= 16;
            }
            int counter = convert.Length;

            for (int i = 0; i < convert.Length; i++)
            {
                hex += convert.Substring(counter - 1, 1);
                counter--;
            }
            Console.WriteLine(hex);
        }
    }
}
