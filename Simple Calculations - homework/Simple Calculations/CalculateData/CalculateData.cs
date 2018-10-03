using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateData
{
    class CalculateData
    {
        static void Main(string[] args)
        {
            var birthDateAsAtring = Console.ReadLine();
            var birthDate = DateTime.ParseExact(birthDateAsAtring, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString("dd-MM-yyyy"));
        }
    }
}
