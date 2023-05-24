namespace Reverse_and_Exclude
{
    public class Program
    {
        static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int dividerN = int.Parse(Console.ReadLine());

            Predicate<int> predicate = i => i % dividerN == 0;

            Func<int[], Predicate<int>, int[]> remove = (num, predicate) => num.Where(i => !predicate(i)).ToArray();

            Func<int[], int[]> reverse = numbers => numbers.Reverse().ToArray();

            inputNumbers = remove(inputNumbers, predicate);
            inputNumbers = reverse(inputNumbers);

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}