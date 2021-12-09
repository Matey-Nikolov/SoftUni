namespace Jagged_Array_Manipulator
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[n][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                double[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[i] = new double[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    jaggedArray[i][j] = numbers[j];
                }
            }

            for (int k = 0; k < jaggedArray.Length - 1; k++)
            {
                if (jaggedArray[k].Length == jaggedArray[k + 1].Length)
                {
                    for (int j1 = 0; j1 < jaggedArray[k].Length; j1++)
                    {
                        jaggedArray[k][j1] *= 2;
                        jaggedArray[k + 1][j1] *= 2;
                    }
                }
                else
                {
                    for (int j2 = 0; j2 < jaggedArray[k].Length; j2++)
                    {
                        jaggedArray[k][j2] /= 2;
                    }

                    for (int j3 = 0; j3 < jaggedArray[k + 1].Length; j3++)
                    {
                        jaggedArray[k + 1][j3] /= 2;
                    }
                }
            }


            while (true)
            {
                string[] AddOrSubtract = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = AddOrSubtract[0];

                if (command == "End")
                    break;

                int row = int.Parse(AddOrSubtract[1]);
                int col = int.Parse(AddOrSubtract[2]);
                int number = int.Parse(AddOrSubtract[3]);

                switch (command)
                {
                    case "Add":
                        if ((row >= 0 && row <= n) && (col >= 0 && col <= n))
                        {
                            jaggedArray[row][col] += number;
                        }
                        break;
                    case "Subtract":
                        if ((row >= 0 && row <= n) && (col >= 0 && col <= n))
                        {
                            jaggedArray[row][col] = jaggedArray[row][col] - number;
                        }
                        break;
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }

            /*
            int[,] matrix = new int[n, n];



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



            while (true)
            {
                string[] AddOrSubtract = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = AddOrSubtract[0];

                if (command == "End")
                    break;

                int row = int.Parse(AddOrSubtract[1]);
                int col = int.Parse(AddOrSubtract[2]);
                int number = int.Parse(AddOrSubtract[3]);

                switch (command)
                {
                    case "Add":
                        if ((row >= 0 && row <= n) && (col >= 0 && col <= n))
                        {
                            matrix[row, col] += number;
                        }
                        break;
                    case "Subtract":
                        if ((row >= 0 && row <= n) && (col >= 0 && col <= n))
                        {
                            matrix[row, col] = matrix[row, col] - number;
                        }
                        break;
                }
            }

            */

        }
    }
}