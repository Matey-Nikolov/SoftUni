namespace Custom_Min_Function
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> smallNumber = numberArr =>
            {
                int min = numberArr[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (min > numberArr[i])
                    {
                        min = numberArr[i];
                    }
                }
                return min;
            };

            Console.WriteLine(smallNumber(numbers));
        }
    }
}