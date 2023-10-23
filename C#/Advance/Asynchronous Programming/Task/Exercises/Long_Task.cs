namespace Long_Task
{
    internal class Program
    {
        static void Main()
        {
            Task task = new Task(Run);

            task.Start();

            //task.Wait();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("----------------");
            }
        }

        static void Run()
        {
            while (true)
            {
                Console.WriteLine("Endless Loop...");
            }
        }
    }
}