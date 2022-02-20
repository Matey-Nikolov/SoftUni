namespace Reversed_Vectors
{
    using System;


    class Program
    {
        static int CountInteration;
        static int[] vector;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            vector = new int[n];
            CountInteration = n;

            ReversedVectors(0);
        }

        public static void ReversedVectors(int n)
        {
            if (n == CountInteration)
            {
                ReversedVectorsPrint();
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[n] = i;
                ReversedVectors(n + 1);
            }
        }

        public static void ReversedVectorsPrint()
        {
            for (int i = CountInteration - 1; i >= 0 ; i--)
            {
                Console.Write($"{vector[i]}");
            }
            Console.WriteLine();
        }
    }
}