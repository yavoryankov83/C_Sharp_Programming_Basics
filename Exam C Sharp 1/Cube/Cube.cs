using System;

class Cube
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int fieldSize = 2 * n - 1;
        int mid = n - 1;

        char empty = ' ';
        char edge = ':';
        char top = '/';
        char side = 'X';

        for (int row = 0; row < fieldSize; row++)
        {
            for (int column = 0; column < fieldSize; column++)
            {
                if (column == 0 && row >= mid ||
                    column == mid && row >= mid ||
                    column == fieldSize - 1 && row >= 0 && row <= mid ||
                    row == 0 && column >= mid ||
                    row == mid && column <= mid ||
                    row == fieldSize - 1 && column <= mid ||
                    column + row == mid ||
                    column + row == fieldSize - 1 + mid ||
                    column + row == fieldSize - 1 && row <= mid)
                {
                    Console.Write(edge);
                }
                else if (column > mid &&
                    column + row <= fieldSize - 1 + mid &&
                    column + row >= fieldSize - 1)
                {
                    Console.Write(side);
                }
                else if (row < mid &&
                    column + row >= mid)
                {
                    Console.Write(top);
                }
                else
                {
                    Console.Write(empty);
                }
            }
            Console.WriteLine();
        }
    }
}
