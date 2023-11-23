namespace Ping_Pong
{
    public class Program
    {
        private static Mutex mutex = new Mutex();
        private const int numberThreads = 5;

        private static bool turn = false;

        static void Main()
        {
            for (int i = 0; i < numberThreads; i++)
            {
                Thread thread = new Thread(ThePingPong);
                thread.Name = $"Thread {i + 1}";
                thread.Start();
            }
        }

        static void ThePingPong()
        {
            try
            {
                mutex.WaitOne();

                Console.WriteLine("Thread has started.");
                if (!turn)
                {
                    Console.WriteLine("***** Ping *****");
                    turn = true;
                }
                else
                {
                    Console.WriteLine("^^^^^ Pong ^^^^^");
                    turn = false;
                }
                Console.WriteLine("Thread is done.");

            }
              
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}