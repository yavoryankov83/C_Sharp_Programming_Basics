using System;

    class MoonGravity
    {
        static void Main(string[] args)
        {
        float weightOnEarth = float.Parse(Console.ReadLine());
        float weihgtOnMoom = weightOnEarth * 0.17f;
        //Console.WriteLine("{0:f3}", weihgtOnMoom);
        Console.WriteLine(weihgtOnMoom.ToString("f3"));
    }
    }

