namespace Mini_Exam_Recursion_and_Backtracking
{
    using System;

    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
 
            Reversed(input, 0);
        }

        private static void Reversed(int input, int spaceCount)
        {
            if (input == 0)
            {
                return;
            }

            Console.Write(new string(' ', spaceCount));
            Console.WriteLine(new string('#', input));
            Reversed(input - 1, spaceCount + 1);
            Console.Write(new string(' ', spaceCount));
            Console.WriteLine(new string('*', input));

        }
    }
}
