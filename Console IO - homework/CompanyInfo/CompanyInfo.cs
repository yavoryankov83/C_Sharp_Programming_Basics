using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddreess = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();
            string companyFaxNumber = Console.ReadLine();
            string companyWebsite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerPhoe = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddreess);
            Console.WriteLine("Tel. {0}", companyPhoneNumber);
            Console.WriteLine(companyFaxNumber == string.Empty ? "Fax: (no fax)" : "Fax: {0}", companyFaxNumber);
            Console.WriteLine(@"Web site: {0}", companyWebsite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoe);

        }
    }
}
