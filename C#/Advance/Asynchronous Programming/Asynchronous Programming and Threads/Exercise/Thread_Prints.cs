namespace Thread_Prints
{
    public class Program
    {
        static void Main()
        {
            Thread threadNumber1 = new Thread(() => PrintNumbers0To10());
            Thread threadNumber2 = new Thread(() => PrintNumbers11To20());

            threadNumber1.Start();
            threadNumber2.Start();

            threadNumber2.Join();
            threadNumber1.Join();
        }

        public static void PrintNumbers0To10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(200);
            }
        }

        public static void PrintNumbers11To20()
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}