using System;

namespace VariationsNoRepetition
{
    public class VariationNoRepetition
    {
        private static int k;
        private static string[] input;
        private static string[] variations;
        private static bool[] isUsed;

        public static void Main()
        {
            input = Console.ReadLine()
                .Split();
            k = int.Parse(Console.ReadLine());
            variations = new string[k];
            isUsed = new bool[input.Length];

            GenerateVariations(0);
        }

        private static void GenerateVariations(int depth)
        {
            if (depth >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!isUsed[i])
                    {
                        isUsed[i] = true;

                        variations[depth] = input[i];
                        GenerateVariations(depth + 1);

                        isUsed[i] = false;
                    }
                }
            }
        }
    }
}