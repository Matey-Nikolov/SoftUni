﻿using System;

namespace Combinations_with_Repetition
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            GenerateCombinations(array, 0, n, 1);
        }

        private static void GenerateCombinations(int[] array, int index, int n, int startNum)
        {
            if (index > array.Length - 1)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = startNum; i <= n; i++)
            {
                array[index] = i;

                GenerateCombinations(array, index + 1, n, i); // startNum = i
            }
        }
    }
}