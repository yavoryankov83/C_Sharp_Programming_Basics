using System;

    class StringsAndObjects
    {
        static void Main(string[] args)
        {
        string word = "Hello";
        string word1 = "Word";
        object all = word + " " + word1;
        string sentence = (string) all;
        Console.WriteLine(sentence);
        }
    }

