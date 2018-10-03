using System;

class Money
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        double totalMoney = N * S / 400.0 * P;

        Console.WriteLine("{0:F3}", totalMoney);
    }
}
