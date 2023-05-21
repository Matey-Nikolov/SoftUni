using System.Globalization;

namespace Custom_Comparator
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Func<int, int, int> sort = (numberOne, numberTwo) =>
            {
                if (numberOne % 2 != 0 && numberTwo % 2 == 0)
                    return 1;
                else if(numberOne % 2 == 0 && numberTwo % 2 != 0)
                    return -1;

                return numberOne.CompareTo(numberTwo);
            };

            Array.Sort(numbers, new Comparison<int>(sort));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}