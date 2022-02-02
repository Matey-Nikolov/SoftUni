namespace NestedLoopsToRecursion
{
    using System;

    class Program
    {
        static int numberOfLoops;
        static int[] array;

        static void Main()
        {
            numberOfLoops = int.Parse(Console.ReadLine());

            array = new int[numberOfLoops];
            NestedLoops(0);
        }

        public static void NestedLoops(int index)
        {
            if (index == numberOfLoops)
            {
                PrintArray();
                return;
            }
            for (int i = 1; i <= numberOfLoops; i++)
            {
                array[index] = i;
                NestedLoops(index + 1);
            }
        }

        public static void PrintArray()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}