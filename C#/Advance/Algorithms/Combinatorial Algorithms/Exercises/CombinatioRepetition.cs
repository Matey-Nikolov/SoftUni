﻿using System;

namespace CombinationRepetition
{
    public class CombinatioRepetition
    {
        private static int k;
        private static string[] input;
        private static string[] combinations;

        public static void Main()
        {
            input = Console.ReadLine()
                .Split();
            k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            GenerateCombinations(0, 0);
        }

        private static void GenerateCombinations(int index, int startIndex)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int currentIndex = startIndex; currentIndex < input.Length; currentIndex++)
            {
                combinations[index] = input[currentIndex];
                GenerateCombinations(index + 1, currentIndex);
            }
        }
    }
}
