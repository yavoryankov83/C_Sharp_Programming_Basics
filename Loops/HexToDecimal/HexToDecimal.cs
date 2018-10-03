using System;

class HexToDecimal
{
    static void Main(string[] args)
    {
        string hex = Console.ReadLine();

        int lastIndeks = hex.Length - 1;

        long dec = 0;

        for (int i = 0; i < hex.Length - 1; i++, lastIndeks--)
        {
            int currentNumberInHex;
            switch (hex[i])
            {
                case 'A':
                    currentNumberInHex = 10;
                    break;
                case 'B':
                    currentNumberInHex = 11;
                    break;
                case 'C':
                    currentNumberInHex = 12;
                    break;
                case 'D':
                    currentNumberInHex = 13;
                    break;
                case 'E':
                    currentNumberInHex = 14;
                    break;
                case 'F':
                    currentNumberInHex = 15;
                    break;
                default:
                    currentNumberInHex = int.Parse(hex[i].ToString());
                    break;
            }

            long hexSum = 1;

            for (int j = 0; j < lastIndeks; j++)
            {
                hexSum *= 16;
            }
            hexSum *= currentNumberInHex;
            dec += hexSum;
        }

        Console.WriteLine(dec);
    }
}
