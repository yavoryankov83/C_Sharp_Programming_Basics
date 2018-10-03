using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        long dec = long.Parse(Console.ReadLine());
        long? remainder = null;
        string binary = null;
    
    while (dec > 0)
	{
            remainder = dec % 2;
            binary = remainder.ToString() + binary;
            dec /= 2;
    }
            Console.WriteLine(binary);
    }
}
