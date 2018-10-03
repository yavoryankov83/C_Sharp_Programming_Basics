using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpJump
{
    class JumpJump
    {
        static void Main(string[] args)
        {
            string instructuions = Console.ReadLine();

            //first solving
            //for (int digit = 0; digit < instructuions.Length;)
            //{
            //    if (instructuions[digit] == '0')
            //    {
            //        Console.WriteLine("Too drunk to go on after {0}!", digit);
            //        break;
            //    }
            //    else if (instructuions[digit] == '^')
            //    {
            //        Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", digit);
            //        break;
            //    }
            //    else if ((instructuions[digit] - '0') % 2 == 0)
            //    {
            //        int value = instructuions[digit] - '0';
            //        int nextDigit = digit + value;

            //        if (nextDigit < 0 || nextDigit >= instructuions.Length)
            //        {
            //            Console.WriteLine("Fell off the dancefloor at {0}!", digit);
            //            break;
            //        }
            //        else
            //        {
            //            digit = nextDigit;
            //        }
            //    }
            //    else if ((instructuions[digit] - '0') % 2 != 0)
            //    {
            //        int value = instructuions[digit] - '0';
            //        int nextDigit = digit - value;

            //        if (nextDigit < 0 || nextDigit >= instructuions.Length)
            //        {
            //            Console.WriteLine("Fell off the dancefloor at {0}!", digit);
            //            break;
            //        }
            //        else
            //        {
            //            digit = nextDigit;
            //        }
            //    }
            //}

            //second solving
            int digit = 0;

            while (0 <= digit && digit < instructuions.Length)
            {
                if (instructuions[digit] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", digit);
                    break;
                }

                if (instructuions[digit] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", digit);
                    break;
                }

                if ((instructuions[digit] - '0') % 2 == 0)
                {
                    digit += instructuions[digit] - '0';
                }
                else
                {
                    digit -= instructuions[digit] - '0';
                }

                if (0 > digit || digit >= instructuions.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", digit);
                }
            }
        }
    }
}