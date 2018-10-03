using System;

class Cube3D
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        char[,] cube = new char[2 * N - 1, 2 * N - 1];

        // loop for cube outside
        for (int i = 0; i < N; i++)
        {
            //upper horizontal side
            //Console.SetCursorPosition(i, 0);
            //Console.Write(':');
            cube[0, i] = ':';

            //bottom horizontal side
            //Console.SetCursorPosition(i, N - 1);
            //Console.Write(':');
            cube[N - 1, i] = ':';

            //left vertical side
            //Console.SetCursorPosition(0, i);
            //Console.Write(':');
            cube[i, 0] = ':';

            //right vertical side
            //Console.SetCursorPosition(N - 1, i);
            //Console.Write(':');
            cube[i, N - 1] = ':';

            //hind bottom horizontal side
            //Console.SetCursorPosition(i + N - 1, 2 * (N - 1));
            //Console.Write(':');
            cube[2 * (N - 1), i + N - 1] = ':';

            //hind right vertical side
            //Console.SetCursorPosition(2 * (N - 1), i + N - 1);
            //Console.Write(':');
            cube[i + N - 1, 2 * (N - 1)] = ':';

            //top right side
            //Console.SetCursorPosition(N - 1 + i, i);
            //Console.Write(':');
            cube[i, N - 1 + i] = ':';

            //bottom right side
            //Console.SetCursorPosition(N - 1 + i, N - 1 + i);
            //Console.Write(':');
            cube[N - 1 + i, N - 1 + i] = ':';

            //bottom left side
            //Console.SetCursorPosition(0 + i, N - 1 + i);
            //Console.Write(':');
            cube[N - 1 + i, i] = ':';
        }
        //loop for cube inside
        for (int i = 2; i < N; i++)
        {
            //Console.SetCursorPosition(N, i);
            //Console.Write('|');

            //Console.SetCursorPosition(N + 1, i + 1);
            //Console.Write('|');

            //Console.SetCursorPosition(N + 2, i + 2);
            //Console.Write('|');

            //fill right cube side with |
            for (int j = 0; j < N - 2; j++)
            {
                //Console.SetCursorPosition(N + j, i + j);
                //Console.Write('|');
                cube[i + j, N + j] = '|';
            }

            //fill right cube side with -
            for (int j = 0; j < N - 2; j++)
            {
                //Console.SetCursorPosition(i + j, N + j);
                //Console.Write('-');
                cube[N + j, i + j] = '-';
            }
        }
        for (int row = 0; row < 2 * N - 1; row++)
        {
            for (int column = 0; column < 2 * N - 1; column++)
            {
                if (cube[row, column] != 0)
                {
                    Console.Write(cube[row, column]);
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
