namespace Print_Number
{
    public class Program
    {
        static readonly object locker = new object();

        static void Main()
        {
            Thread threadPrint1 = new Thread(Print);
            threadPrint1.Start();

            Thread threadPrint2 = new Thread(Print);
            threadPrint2.Start();
        }

        public static void Print()
        {
            Monitor.Enter(locker);

            try
            {
                Console.WriteLine("Thread entered into the critical section.");

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Number: {i}");
                }
            }
            catch (SynchronizationLockException exception)
            {
                Console.WriteLine(exception.Message);
            }

            finally
            {
                Monitor.Exit(locker); // without this error
                Console.WriteLine("Thread released.");
            }

        }
    }
}