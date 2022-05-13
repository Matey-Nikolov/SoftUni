namespace Searching
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // Linear Search

            int[] arrayNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int givenNumber = int.Parse(Console.ReadLine());

            int indexSave = -1;

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (givenNumber == arrayNumber[i])
                {
                    indexSave = i;
                    Console.WriteLine(indexSave);
                    return;
                }
            }

            Console.WriteLine(indexSave);
        }
    }
}