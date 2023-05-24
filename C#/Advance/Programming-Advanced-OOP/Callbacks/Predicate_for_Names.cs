namespace Predicate_for_Names
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string[], string[]> lengthInput = arr => arr.Where(x => x.Length <= n).ToArray();

            Action<string[]> print = arr =>
            {
                foreach (var s in arr)
                {
                    Console.WriteLine(s);
                }
            };

            print(lengthInput(input));
        }
    }
}