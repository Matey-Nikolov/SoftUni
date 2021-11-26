namespace Pascal_Triangle_Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // Hakov book - C#

            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n + 1][];
            for (int row = 0; row < n; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{triangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}