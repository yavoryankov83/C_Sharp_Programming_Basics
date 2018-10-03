using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var medics = 7;

            var examinedPatience = 0;
            var unexaminedPatience = 0;

            for (int i = 1; i <= period; i++)
            {
                var patience = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && (unexaminedPatience > examinedPatience))
                {
                    medics ++;
                }
                if (patience > medics)
                {
                    examinedPatience += medics;
                    unexaminedPatience += patience - medics;
                }
                else
                {
                    examinedPatience += patience;
                }
            }
            Console.WriteLine($"Treated patients: {examinedPatience}.");
            Console.WriteLine($"Untreated patients: {unexaminedPatience}.");
        }
    }
}
