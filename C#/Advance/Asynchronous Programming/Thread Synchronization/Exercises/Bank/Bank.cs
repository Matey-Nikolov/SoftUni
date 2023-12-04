namespace Bank
{
    public class Program
    {
        static void Main()
        {
            Thread[] threads = new Thread[10];

            Account acc = new Account(500);

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(() =>
                {
                    acc.Withdraw(100);
                });

                threads[i] = t;
            }

            for (int i = 0; i < 10; i++)
            {
                lock (threads[i])
                {
                    threads[i].Start();
                }
            }
        }
    }
}