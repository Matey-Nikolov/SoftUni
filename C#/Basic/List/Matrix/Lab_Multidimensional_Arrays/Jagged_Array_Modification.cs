namespace Jagged_Array_Modification
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            while (true)
            {
                string[] AddOrSubtract = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = AddOrSubtract[0];

                if (command == "END")
                    break;

                int row = int.Parse(AddOrSubtract[1]);
                int col = int.Parse(AddOrSubtract[2]);
                int number = int.Parse(AddOrSubtract[3]);

                switch (command)
                {
                    case "Add":
                        if ((row < matrix.GetLength(0) && row >= 0) && (col < matrix.GetLength(1) && col >= 0))
                            matrix[row, col] += number;
                        else
                            Console.WriteLine("Invalid coordinates");

                        break;
                    case "Subtract":
                        if ((row < matrix.GetLength(0) && row >= 0) && (col < matrix.GetLength(1) && col >= 0))
                            matrix[row, col] -= number;
                        else
                            Console.WriteLine("Invalid coordinates");
                        break;
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}