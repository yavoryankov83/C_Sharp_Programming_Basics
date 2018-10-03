using System;

class Age
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birthday in format(dd.mm.yyyy):");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthDay.Year;   //calculate the age
        birthDay = new DateTime(today.Year, birthDay.Month, birthDay.Day);    //assign my birthday on current year          
        if (today < birthDay)   //if my birthday didn't pass this year                                
            age = age - 1;      //then decrease the age                        
        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
    }
}
