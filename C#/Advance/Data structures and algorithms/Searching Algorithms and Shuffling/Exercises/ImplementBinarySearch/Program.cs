namespace ImplementBinarySearch
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

            int numberFind = int.Parse(Console.ReadLine());

            BinarySearch search = new BinarySearch();
            int findYesNo = search.IndexOf(numbers, numberFind);

            Console.WriteLine(findYesNo);
        }
    }
}