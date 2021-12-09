namespace Bombs_Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            FillMatrix(matrix);

            int[] indexBombs = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int find = 0; find < indexBombs.Length - 1;)
            {
                int rowBomb = indexBombs[find++];
                int colBomb = indexBombs[find++];

                if (matrix[rowBomb, colBomb] > 0)
                {
                    IfCheck(n, matrix, rowBomb, colBomb);
                }
            }

            FinalWrite(matrix);
        }

        public static void FinalWrite(int[,] matrix)
        {
            int sum = 0;
            int countAlive = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        countAlive++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {countAlive}");
            Console.WriteLine($"Sum: {sum}");

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write($"{matrix[k, l]} ");
                }
                Console.WriteLine();
            }
        }


        public static void FillMatrix(int[,] matrix)
        {
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
        }

        public static void IfCheck(int n, int[,] matrix, int rowBomb, int colBomb)
        {

            if (rowBomb - 1 >= 0 && rowBomb - 1 < n && colBomb - 1 >= 0 && colBomb - 1 < n && matrix[rowBomb - 1, colBomb - 1] > 0)
                matrix[rowBomb - 1, colBomb - 1] -= matrix[rowBomb, colBomb];
            if (rowBomb - 1 >= 0 && rowBomb - 1 < n && colBomb >= 0 && colBomb < n && matrix[rowBomb - 1, colBomb] > 0) 
                matrix[rowBomb - 1, colBomb] -= matrix[rowBomb, colBomb];
            if (rowBomb - 1 >= 0 && rowBomb - 1 < n && colBomb + 1 >= 0 && colBomb + 1 < n && matrix[rowBomb - 1, colBomb + 1] > 0) 
                matrix[rowBomb - 1, colBomb + 1] -= matrix[rowBomb, colBomb];

            if (rowBomb >= 0 && rowBomb < n && colBomb - 1 >= 0 && colBomb - 1 < n && matrix[rowBomb, colBomb - 1] > 0) 
                matrix[rowBomb, colBomb - 1] -= matrix[rowBomb, colBomb];
            if (rowBomb >= 0 && rowBomb < n && colBomb + 1 >= 0 && colBomb + 1 < n && matrix[rowBomb, colBomb + 1] > 0) 
                matrix[rowBomb, colBomb + 1] -= matrix[rowBomb, colBomb];

            if (rowBomb + 1 >= 0 && rowBomb + 1 < n && colBomb - 1 >= 0 && colBomb - 1 < n && matrix[rowBomb + 1, colBomb - 1] > 0) 
                matrix[rowBomb + 1, colBomb - 1] -= matrix[rowBomb, colBomb];
            if (rowBomb + 1 >= 0 && rowBomb + 1 < n && colBomb >= 0 && colBomb < n && matrix[rowBomb + 1, colBomb] > 0) 
                matrix[rowBomb + 1, colBomb] -= matrix[rowBomb, colBomb];
            if (rowBomb + 1 >= 0 && rowBomb + 1 < n && colBomb + 1 >= 0 && colBomb + 1 < n && matrix[rowBomb + 1, colBomb + 1] > 0) 
                matrix[rowBomb + 1, colBomb + 1] -= matrix[rowBomb, colBomb];

            matrix[rowBomb, colBomb] = 0;
        }
    }
}