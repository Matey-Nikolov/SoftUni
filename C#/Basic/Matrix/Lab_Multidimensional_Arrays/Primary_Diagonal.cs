namespace Primary_Diagonal
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[columns, columns];

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                for (int a = 0; a < input.Length; a++)
                {
                    matrix[i, a] = input[a];

                    if (i == a)
                        sum += matrix[i, a];
                }
            }
            Console.WriteLine(sum);
        }
    }
}