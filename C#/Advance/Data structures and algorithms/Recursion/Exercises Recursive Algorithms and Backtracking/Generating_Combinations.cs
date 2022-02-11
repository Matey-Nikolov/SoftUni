namespace Generating_Combinations
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] set = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            GenerateCombinations(array, 0, 0, set);
        }

        private static void GenerateCombinations(int[] array, int index, int startNum, int[] set)
        {

            if (index > array.Length - 1)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            // startNum == index of element from set.
            for (int i = startNum; i < set.Length; i++)
            {
                array[index] = set[i];
                GenerateCombinations(array, index + 1, i + 1, set );
            }
        }
    }
}