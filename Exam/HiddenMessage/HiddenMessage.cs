using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenMessage
{
    class HiddenMessage
    {
        static void Main(string[] args)
        {
            string code = "";

            do
            {
                string index = Console.ReadLine();
                int indexNumber = int.Parse(index);

                if (index == "end")
                {
                    Console.WriteLine(code);
                    break;
                }
                string step = Console.ReadLine();
                int stepNumber = int.Parse(step);

                string line = Console.ReadLine();

                for (int i = indexNumber; i < line.Length;)
                {
                    if (i == 0)
                    {
                        code = code + line[0];
                        i = i + stepNumber;
                        if (i > (line.Length - 1) || i < 0)
                        {
                            break;
                        }
                    }
                    else if (i < 0)
                    {
                        if ((i * -1) > line.Length)
                        {
                            break;
                        }
                        code = code + line[(line.Length) - (i * -1)];
                        i = i + stepNumber;
                        if (i > (line.Length - 1) || i == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        code = code + line[i];
                        i = i + stepNumber;
                        if (i > (line.Length - 1) || i < 0)
                        {
                            break;
                        }
                    }

                }

            } while (true);
        }
    }
}
