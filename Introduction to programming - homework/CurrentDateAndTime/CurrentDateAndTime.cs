using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;

            string[] cultureNames =
                {"en-US", "en-GB", "fr-FR",
                "de-DE", "ru-RU"};
            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}: {1}", cultureName, localDate.ToString(culture));
            }
        }
    }
}
