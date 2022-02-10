using System;
using System.Linq;

namespace ReverseArrayRecursive
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            ReverseArray(array, 0);
        }

        public static void ReverseArray(int[] array, int index)
        {
            if (index == array.Length)
            {
                return;
            }

            ReverseArray(array, index + 1);

            Console.Write(array[index] + " ");
        }
    }
}