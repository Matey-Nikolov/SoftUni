namespace RecursiveArraySum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // SumTwoElements(5, 7);

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

           // int[] array = new int[] { 1, 2, 3, 4, 5};
            int result = SumArray(array, 0);
            Console.WriteLine(result);
        }

        static int SumArray(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            int currentSum = array[index] + SumArray(array, index + 1);
            return currentSum;
        }

        static void SumTwoElements(int a, int b)
        {
            int result = a + b;
            printResult(result);
        }

        private static void printResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}