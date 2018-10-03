using System;

class EncodingSum
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int M = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = 0; i < text.Length - 1; i++)
        {
            char ch = text[i];
           
            if (char.IsDigit(ch))
            {
                result *= ch - '0'; //char.GetNumericValue(ch);
            }
            else if (char.IsLetter(ch)) //('A' <= ch && ch <= 'Z') || ('a' <= ch && ch <= 'z')
            {
                char toLower = char.ToLower(ch);
                result += toLower - 'a'; 
            }
            else
            {
                result %= M;
            }
        }
    }
}
