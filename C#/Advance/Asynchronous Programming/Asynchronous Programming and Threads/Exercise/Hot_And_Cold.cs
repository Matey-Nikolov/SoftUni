namespace Hot_And_Cold
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
                Console.WriteLine("Hot");
                Thread.Sleep(200);
            }
        }

        public static void PrintCold()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Cold");
                Thread.Sleep(200);
            }
        }
    }
}