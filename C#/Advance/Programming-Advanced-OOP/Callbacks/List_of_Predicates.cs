namespace List_of_Predicates
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> isDivisible = (i, d) => i % d == 0;

            for (int i = 1; i <= n; i++)
            {
                bool divisible = true;

                foreach (var number in input)
                {
                    if (!isDivisible(i, number))
                    {
                        divisible = false;
                        break;
                    }
                }

                if (divisible)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}