namespace RecursionFactorial
{
    using System;

    class Program
    {
        static void Main()
        {
            long result = long.Parse(Console.ReadLine());
            long result1 = RecursionFactorial(result);
            Console.WriteLine(result1);
        }

        public static long RecursionFactorial(long currentNumber)
        {
            if (currentNumber == 0)
            {
                return 1;
            }

            return currentNumber * RecursionFactorial(currentNumber - 1);
        }
    }
}