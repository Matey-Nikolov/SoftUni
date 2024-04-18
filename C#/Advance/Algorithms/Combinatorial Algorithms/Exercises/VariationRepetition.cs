using System;

namespace VariationRepetition
{
    public class VariationRepetition
    {
        private static int k;
        private static string[] input;
        private static string[] variations;

        public static void Main()
        {
            input = Console.ReadLine()
                .Split();
            k = int.Parse(Console.ReadLine());
            variations = new string[k];

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
                    variations[depth] = input[i];
                    GenerateVariations(depth + 1);
                }
            }
        }
    }
}
