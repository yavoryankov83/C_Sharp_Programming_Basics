using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            int currentChar;
            int counter = hexadecimalNumber.Length;
            long dec = 0;

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                long temp = 1;
                long hexToDecimal = 1;
                if (int.TryParse(hexadecimalNumber.Substring(counter - 1, 1), out currentChar))
                {
                    currentChar = Convert.ToInt32(hexadecimalNumber.Substring(counter - 1, 1));
                }
                else
                {
                    if (hexadecimalNumber.Substring(counter - 1, 1) == "A")
                    {
                        currentChar = 10;
                    }
                    if (hexadecimalNumber.Substring(counter - 1, 1) == "B")
                    {
                        currentChar = 11;
                    }
                    if (hexadecimalNumber.Substring(counter - 1, 1) == "C")
                    {
                        currentChar = 12;
                    }
                    if (hexadecimalNumber.Substring(counter - 1, 1) == "D")
                    {
                        currentChar = 13;
                    }
                    if (hexadecimalNumber.Substring(counter - 1, 1) == "E")
                    {
                        currentChar = 14;
                    }
                    if (hexadecimalNumber.Substring(counter - 1, 1) == "F")
                    {
                        currentChar = 15;
                    }
                }

                for (int j = 1; j <= i; j++)
                {
                    hexToDecimal = temp *= 16;
                }
                dec += (currentChar * hexToDecimal);
                counter--;

            }
            Console.WriteLine(dec);
        }
    }
}
