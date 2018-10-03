using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {   
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int myAge = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now < birthday.AddYears(myAge))
            {
                myAge--;
            }
            Console.WriteLine(myAge);
            Console.WriteLine(myAge + 10);
        }

    }
}

//DateTime dateToday = DateTime.Now;
//var myAge = dateToday.Year - userDate.Year;
//Console.WriteLine(myAge);
//Console.WriteLine(myAge + 10);



//var myAgeAfterTenYears = myAge.Add;







////get age as user input
//string input = Console.ReadLine();
////convert input into the c# date format
//DateTime age = Convert.ToDateTime(input);
////get what year is it NOW
//int currentYear = DateTime.Now.Year;

//int currentAge;
//int ageInTenYears;

////check if you have had your birthday this year or edge case: is your birthday today

//if (age.Month > DateTime.Now.Month)
//{
//    currentAge = (currentYear - age.Year) - 1;
//    ageInTenYears = currentAge + 10;
//}
//else if (age.Month == DateTime.Now.Month && age.Date == DateTime.Now.Date)
//{
//    currentAge = currentYear - age.Year;
//    ageInTenYears = currentAge + 10;
//}
//else
//{
//    currentAge = currentYear - age.Year;
//    ageInTenYears = currentAge + 10;
//}

//Console.WriteLine(currentAge);
//Console.WriteLine(ageInTenYears);











//Console.WriteLine();
//DateTime birthday = DateTime.Parse(Console.ReadLine());
//DateTime today = DateTime.Now;
//int age = today.Year - birthday.Year;

//if (today < birthday.AddYears(age)) age--;


//Console.WriteLine(age);
//Console.WriteLine(age + 10);




//DateTime userBirthday = DateTime.Parse(Console.ReadLine());
//DateTime timeToday = DateTime.Today;
//long period = timeToday.Subtract(userBirthday).Ticks;
//int years = new DateTime(period).Year - 1;
//Console.WriteLine(years);
//int futureYears = years + 10;
//Console.WriteLine(futureYears);




///// Parse console input to DateTime
//Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//string input = (Console.ReadLine());
//string dateFormat = "MM'.'dd'.'yyyy";
//CultureInfo provider = CultureInfo.InvariantCulture;

//DateTime birthDate = DateTime.ParseExact(input, dateFormat, provider);

///// Check whether the birthday is passed in current year - return true or false
//bool isBirthdayPassed = DateTime.Now.Month > birthDate.Month ||
//     (DateTime.Now.Month == birthDate.Month
//     && DateTime.Now.Day > birthDate.Day);

//int ageNow;

//if (isBirthdayPassed)
//{
//    ageNow = DateTime.Now.Year - birthDate.Year;
//}
//else
//{
//    ageNow = DateTime.Now.Year - birthDate.Year - 1;
//}

//var ageAfterTenYears = ageNow + 10;

//Console.WriteLine(ageNow);
//Console.WriteLine(ageAfterTenYears);





//DateTime date = DateTime.Today;

//string birthday = Console.ReadLine();
//int inputYear = int.Parse(birthday.Substring(6, 4));
//int inputMonth = int.Parse(birthday.Substring(0, 2));
//int age = date.Year - inputYear;
//if (inputMonth > date.Month)
//{
//    age--;
//}

//int ageAfterTenYears = age + 10;

//Console.WriteLine(age);
//Console.WriteLine(ageAfterTenYears);

//Console.WriteLine("Enter date of birthday (MM.DD.YYYY): ");
//string[] userInput = Console.ReadLine().Split('.');
//string date = String.Join(".", userInput);
//DateTime userDate = DateTime.ParseExact(userInput, "MM.DD.YYYY", null);
//DateTime dateToday = DateTime.Now;
//var myAge = dateToday.Year - userDate.Year;
//Console.WriteLine(myAge);
//Console.WriteLine(myAge + 10);

//DateTime input = DateTime.Parse(Console.ReadLine());
//TimeSpan difference = DateTime.Now - input;
//int years = (int)(difference.TotalDays / 365);
//Console.WriteLine(years);
//Console.WriteLine(years + 10);
