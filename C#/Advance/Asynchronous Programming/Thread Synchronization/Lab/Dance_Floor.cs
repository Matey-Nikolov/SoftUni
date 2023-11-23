namespace Dance_Floor
{
    public class Program
    {
        static Semaphore semaphore = new Semaphore(3, 3);

        static void Main()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = new Thread(TheDanceFloor);
                thread.Name = $"{i}";
                thread.Start(i);
            }
        }

        public static void TheDanceFloor(object id)
        {
            semaphore.WaitOne();

            Console.WriteLine($"Dancer number {Thread.CurrentThread.Name} entered.");
            
            Thread.Sleep(300 * (int)id);

            Console.WriteLine($"Number: {Thread.CurrentThread.Name} left");

            semaphore.Release();
        }
    }
}