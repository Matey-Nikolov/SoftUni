namespace RecursiveDrawing
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Draw(n);
        }

        public static void Draw(int v)
        {
            if (v == 0)
            {
                return;
            }

            // Pre-Action
            Console.WriteLine(new string('*', v));
            // Recursion
            Draw(v - 1);
            //Post-Action
            Console.WriteLine(new string('#', v));
        }
    }
}