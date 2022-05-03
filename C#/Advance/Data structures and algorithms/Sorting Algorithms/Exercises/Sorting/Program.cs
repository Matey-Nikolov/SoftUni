namespace Sorting
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                int currentIndex = i;
                
                while (currentIndex > 0 && numbers[currentIndex] < numbers[currentIndex - 1])
                {
                    Swap(numbers, currentIndex, currentIndex - 1);
                    currentIndex--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Swap(int[] numbers, int currentIndex1, int currentIndex2)
        {
            int oldNumer = numbers[currentIndex1];
            numbers[currentIndex1] = numbers[currentIndex2];
            numbers[currentIndex2] = oldNumer;
        }
    }
}