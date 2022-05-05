namespace MergeSort
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            MergeSortClass.Sort(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}