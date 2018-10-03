using System;

    class BitExchange
    {
        static void Main(string[] args)
        {
        uint number = uint.Parse(Console.ReadLine());

        int maskFirst = 1;
        maskFirst = 1 << 3;
        int BitValueFirst = (int)number & maskFirst;
        BitValueFirst = BitValueFirst >> 3;
        int maskSecond = 1;
        maskSecond = 1 << 24;
        int BitValueSecond = (int)number & maskSecond;
        BitValueSecond = BitValueSecond >> 24;

        int maskThird = 1;
        maskThird = 1 << 4;
        int BitValueThird = (int)number & maskThird;
        BitValueThird = BitValueThird >> 4;
        int maskFourth = 1;
        maskFourth = 1 << 25;
        int BitValueFourth = (int)number & maskFourth;
        BitValueFourth = BitValueFourth >> 25;

        int maskFifth = 1;
        maskFifth = 1 << 5;
        int BitValueFifth = (int)number & maskFifth;
        BitValueFifth = BitValueFifth >> 5;
        int maskSisth = 1;
        maskSisth = 1 << 26;
        int BitValueSisht = (int)number & maskSisth;
        BitValueSisht = BitValueSisht >> 26;
        Console.WriteLine(number);
    }
    }

