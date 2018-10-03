using System;

    class SumOfTreeNumbers
    {
        static void Main(string[] args)
        {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        bool isTrue = (a >= -1000) && (a <= 1000) && (b >= -1000) && (b <= 1000) && (c >= -1000) && (c <= 1000);
        float sum = a + b + c;

        while (isTrue)
        {
            Console.WriteLine(sum);
            break;
        }
        
        }
    }

