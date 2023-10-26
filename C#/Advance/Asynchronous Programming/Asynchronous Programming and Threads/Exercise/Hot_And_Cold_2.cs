namespace Hot_And_Cold_2
{
    public class Program
    {
        static void Main()
        {
            Thread thread = new Thread(() => PrintCold());
            thread.Start();

            PrintHot();

            thread.Join();
        }

        public static void PrintHot()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("Hot");
            }
        }

        public static void PrintCold()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(" Cold ");
        }
    }
}