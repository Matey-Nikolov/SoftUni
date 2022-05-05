namespace Quicksort
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            // https://www.programiz.com/dsa/quick-sort
            Quick quickSort = new Quick();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int size = numbers.Length;

            quickSort.QuickSort(numbers, 0, size - 1);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}