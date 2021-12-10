namespace CountSameValuesinArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string currentNumber = numbers[i];

                if (!counts.ContainsKey(currentNumber))
                    counts.Add(currentNumber, 1);
                else
                     counts[currentNumber]++;
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
