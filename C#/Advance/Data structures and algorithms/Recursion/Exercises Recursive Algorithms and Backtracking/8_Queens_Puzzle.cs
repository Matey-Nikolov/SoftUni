namespace _8_Queens_Puzzle
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        const int Size = 8;
        static int[,] matrix = new int[Size, Size];

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void Main()
        {
            PlaceQueens(0);
        }

        static void PlaceQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }

            for (int col = 0; col < Size; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkAttackedPosition(row, col);
                    PlaceQueens(row + 1);
                    UnMarkAttackedPositions(row, col);
                }
            }
        }

        private static void UnMarkAttackedPositions(int row, int col)
        {
            matrix[row, col] = 0;
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
        }

        private static void MarkAttackedPosition(int row, int col)
        {
            matrix[row, col] = 1;
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(col + row);
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            bool isNotFreePosition = attackedRows.Contains(row)
                || attackedCols.Contains(col)
                || attackedLeftDiagonals.Contains(col - row)
                || attackedRightDiagonals.Contains(col + row);

            return !isNotFreePosition;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    // TODO
                    if (matrix[row, col] == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}