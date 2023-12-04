namespace Reserve_Seat_on_a_Train
{
    public class Program
    {
        static bool reserve;
        static object lockObject = new object();

        static void Main()
        {
            Thread thread1 = new Thread(Reserve);
            Thread thread2 = new Thread(Reserve);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        static void Reserve()
        {
            lock (lockObject)
            {
                if (!reserve)
                {
                    Console.WriteLine("Reserved");
                    reserve = true;
                }
            }
        }
    }
}