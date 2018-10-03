using System;

class Calculate
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        bool isValid = n > 2 && n < 10 && x > 0.5 && x < 100;

        double factN = 1;
        double multiX = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multiX *= x;
            result += factN / multiX;
        }
        if (isValid)
        {
            Console.WriteLine("{0:F5}", result);
        }
        else
        {
            Console.WriteLine("wrong input");
        }
        
    }
}
