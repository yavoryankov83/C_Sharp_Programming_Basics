using System;

    class CompanyInfo
    {
        static void Main(string[] args)
        {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhoneNumber= Console.ReadLine();
        string companyFaxNumber = Console.ReadLine();
        string companyWebSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine(string.Empty == companyFaxNumber.ToString() ? "(no fax)" : "Fax: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {3}, tel. {4})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

