namespace Find_Evens_or_Odds
{
    public class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            int start = input[0];
            int end = input[1];

            Predicate<int> predicate = null;

            switch (command)
            {
                case "odd":
                    predicate = num => num % 2 != 0;
                    break;
                case "even":
                    predicate = num => num % 2 == 0;
                    break;
            }

            for (int i = start; i <= end; i++)
            {
                if (predicate(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}