using System;
using System.Collections.Generic;

namespace PermutationsRepetitions
{
    public class PermutationsRepetition
    {
        private static string[] permutations;

        public static void Main()
        {
            permutations = Console.ReadLine()
                .Split();
            GeneratePermutations(0);
        }

        private static void GeneratePermutations(int index)
        {
            if (index >= permutations.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            GeneratePermutations(index + 1);

            HashSet<string> list = new HashSet<string> { permutations[index] };

            for (int currentIndex = index + 1; currentIndex < permutations.Length; currentIndex++)
            {
                if (!list.Contains(permutations[currentIndex]))
                {
                    Swap(index, currentIndex);

                    GeneratePermutations(index + 1);
                    
                    Swap(index, currentIndex);

                    list.Add(permutations[currentIndex]);
                }
            }
        }

        private static void Swap(int first, int second)
        {
            (permutations[first], permutations[second]) = (permutations[second], permutations[first]);
        }
    }
}
