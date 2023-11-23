namespace Shared_Variable
{
    public class Program
    {
        private static int counter;
        static readonly object locker = new object();

        static void Main()
        {
            Thread threadPrintStars = new Thread(PrintStar);
            threadPrintStars.Start();

            Thread threadPrintPlus = new Thread(PrintPlus);
            threadPrintPlus.Start();
        }

        static void PrintStar()
        {
            lock (locker)
            {
                for(counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine(" * "); 
                }
            }
        }

        private static void PrintPlus()
        {
            lock (locker)
            {
                for (counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine(" + ");
                }
            }
        }
    }
}