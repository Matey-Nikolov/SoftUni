namespace Multiple_Threads
{
    public class Program
    {
        static void Main()
        {
            Thread threadMakingRequests = new Thread(() => MakingRequests());
            Thread threadAccessingDatabase = new Thread(() => AccessingDatabase());
            Thread threadOperations = new Thread(() => Operations());
        
            threadMakingRequests.Start();
            threadAccessingDatabase.Start();
            threadOperations.Start();

            threadMakingRequests.Join();
            threadAccessingDatabase.Join();
            threadOperations.Join();
        }

        static void Operations()
        {
            Console.WriteLine("Operations started using Thread 3");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Operations: {i}");
            }

            Console.WriteLine("Operations ended using Thread 3");
        }

        static void AccessingDatabase()
        {
            Console.WriteLine("Access database started using Thread 2");

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Performing the database operation started");
                    Thread.Sleep(1000);
                    Console.WriteLine("Performing the database operation completed");
                }
                else
                    Console.WriteLine($"Access database: {i}");
            }

            Console.WriteLine("Access database ended using Thread 2");
        }

        static void MakingRequests()
        {
            Console.WriteLine("Making requests started using Thread 1");

            for (int i = 1; i <= 5; i++) 
            {
                Console.WriteLine($"Making requests: {i}");
            }

            Console.WriteLine("Making requests ended using Thread 1");
        }
    }
}