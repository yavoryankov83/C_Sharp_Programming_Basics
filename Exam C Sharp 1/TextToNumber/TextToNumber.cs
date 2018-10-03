using System;

class TextToNumber
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char symbol = text[i];

            if (symbol == '@')
            {
                break;
            }

            if (char.IsDigit(symbol)) //('0' <= char && char <= '9')
            {
                result *= symbol - '0';
            }

            else if (char.IsLower(symbol)) //('a' <= symbol && symbol <= 'z')
            {
                result += symbol - 'a';
            }

            else if (char.IsUpper(symbol)) //('A' <= symbol && symbol <= 'Z')
            {
                result += symbol - 'A';
            }
            else
            {
                result %= m;
            }
        }
        Console.WriteLine(result);
    }
}
