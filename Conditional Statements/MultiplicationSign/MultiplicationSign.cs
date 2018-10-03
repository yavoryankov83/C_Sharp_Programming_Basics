using System;

    class MultiplicationSign
    {
        static void Main(string[] args)
        {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double third = double.Parse(Console.ReadLine());

        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("0");
        }
        if (first > 0 && second > 0 && third > 0)
        {
            Console.WriteLine("+");
        }
        else if (first > 0 && second > 0 && third < 0)
        {
            Console.WriteLine("-");
        }
        else if (first > 0 && second < 0 && third < 0)
        {
            Console.WriteLine("+");
        }
        else if (first > 0 && second < 0 && third > 0)
        {
            Console.WriteLine("-");
        }
        else if (first < 0 && second > 0 && third > 0)
        {
            Console.WriteLine("-");
        }
        else if (first < 0 && second > 0 && third < 0)
        {
            Console.WriteLine("+");
        }
        else if (first < 0 && second < 0 && third > 0)
        {
            Console.WriteLine("+");
        }
        else if (first < 0 && second < 0 && third < 0)
        {
            Console.WriteLine("-");
        }
    }
}
