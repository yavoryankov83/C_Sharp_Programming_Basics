using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
        int? a = null;
        double? b = null;
        int c = (int) a + 5;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

