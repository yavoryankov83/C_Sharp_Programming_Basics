﻿using System;

class Decoding
{
    static void Main(string[] args)
    {
        int salt = int.Parse(Console.ReadLine());
        int position = 0;

        while (true)
        {
            int charCode = Console.Read();
            char ch = (char)charCode;

            if (ch == '@')
            {
                break;
            }

            int newCode = 0;
            if (char.IsLetter(ch))
            {
                newCode = charCode * salt + 1000;
            }

            else if (char.IsDigit(ch))
            {
                newCode = charCode + salt + 500;
            }
            else
            {
                newCode = charCode - salt;
            }

            if (position % 2 == 0)
            {
                Console.WriteLine("{0:F2}", newCode / 100.0);
            }
            else
            {
                Console.WriteLine(newCode * 100);
            }
            position++;
        }

    }
}
