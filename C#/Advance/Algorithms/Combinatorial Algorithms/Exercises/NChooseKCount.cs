using System;
using System.Reflection;

namespace NChooseKCount
{
    public class NChooseKCount
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Binom(n, k));
        }

        private static int possibleCombinations = 0;

        /*
            decimal result = 1;
            for (int i = 1; i <= K; i++)
            {
                result *= N - (K - i);
                result /= i;
            }
            return result;
        */

        private static int Binom(int row, int col)
        {
            //pascal triangle
            int result = 1;

            for (int i = 1; i <= col; i++)
            {
                result *= row - (col - i);
                result /= i;
            }
            
            return result;
        }
    }
}