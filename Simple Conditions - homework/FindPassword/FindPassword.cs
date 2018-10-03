using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPassword
{
    class FindPassword
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            Console.WriteLine(password == "s3cr3t!P@ssw0rd" ? "Welcome" : "Wrong password!");
        }
    }
}
