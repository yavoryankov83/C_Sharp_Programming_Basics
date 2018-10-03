using System;

class DecimalToHex
{
    static void Main(string[] args)
    {
        long dec = long.Parse(Console.ReadLine());

        string hex = null;

        long? reminder = null;

        while (dec > 0)
        {
            reminder = dec % 16;

            switch (reminder)
            {
                case 10:
                    hex = 'A' + hex;
                    break;
                case 11:
                    hex = 'B' + hex;
                    break;
                case 12:
                    hex = 'C' + hex;
                    break;
                case 13:
                    hex = 'D' + hex;
                    break;
                case 14:
                    hex = 'E' + hex;
                    break;
                case 15:
                    hex = 'F' + hex;
                    break;
                default:
                    hex = reminder.ToString() + hex;
                    break;
            }
            dec /= 16;
        }
        Console.WriteLine(hex);
    }
}
