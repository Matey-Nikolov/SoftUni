namespace Maximal_Sum_3x3
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
           int[] nM = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = nM[0];
            int m = nM[1];

            int[,] matrix = new int[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int maxRow = 0;
            int maxCol = 0;
            int maxSum = 0;

            for (int a = 0; a < matrix.GetLength(0) - 2; a++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 2; k++)
                {
                    int sum = 0;
                    sum += matrix[a, k] + matrix[a, k + 1] + matrix[a, k + 2] + matrix[a + 1, k] + matrix[a + 1, k + 1] + matrix[a + 1, k + 2] + matrix[a + 2, k] + matrix[a + 2, k + 1] + matrix[a + 2, k + 2];
                    // sum += matrix[a + 1, k] + matrix[a + 1, k + 1] + matrix[a + 1, k + 2];
                    //  sum += matrix[a + 2, k] + matrix[a + 2, k + 1] + matrix[a + 2, k + 2];

                    if (maxSum < sum)
                    {
                        maxRow = a;
                        maxCol = k;
                        maxSum = sum;
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
        }
    }
}