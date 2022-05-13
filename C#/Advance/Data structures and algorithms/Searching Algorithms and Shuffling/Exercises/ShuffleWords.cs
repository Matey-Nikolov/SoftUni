namespace ShuffleWords
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random randomIndex = new Random();

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                int shuffleIndex = randomIndex.Next(i + 1);
                string temp = input[i];
                input[i] = input[shuffleIndex];
                input[shuffleIndex] = temp;
            
                Console.WriteLine(input[i]);
            }

        }
    }
}