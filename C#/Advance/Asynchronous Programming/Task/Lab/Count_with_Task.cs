namespace Count_with_Task
{
    internal class Program
    {
        static void Main()
        {
            //1
            /*
            Console.WriteLine("Counter starting");

            Task task = new Task(Counter);
            task.Start();

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread ending.");
            */
            //2

            Console.WriteLine("Main thread starting.");

            Task task = new Task(Counter);
            task.Start();

            task.Wait();

            Console.WriteLine("Main thread ending.");
        }

        static void Counter()
        {
            Console.WriteLine("Counter starting");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"The count is {count}");
            }

            Console.WriteLine("Counter terminating");
        }
    }
}