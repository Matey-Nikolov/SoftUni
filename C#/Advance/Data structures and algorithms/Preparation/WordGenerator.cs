namespace WordGenerator
{
    using System;

    class Program
    {
        static char[] array;

        static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            array = new char[inputN];

            if (inputN > 26)
            {
                inputN = 26;
            }

            NestedLoopsWordGenerator(inputN, 0);
        }

        public static void NestedLoopsWordGenerator(int inputN, int current)
        {
            if (current >= inputN)
            {
                Console.WriteLine(string.Join("", array));
                return;
            }

            for (int i = 97; i < 97 + inputN; i++)
            {
                array[current] = (char)i;
                NestedLoopsWordGenerator(inputN, current + 1);
            }
        }
    }
}