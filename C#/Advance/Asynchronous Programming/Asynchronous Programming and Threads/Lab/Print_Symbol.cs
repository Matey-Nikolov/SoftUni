namespace Print_Symbol
{
    public class Program
    {
        static void Main()
        {
            Thread thread = new Thread(() => Go('O'));
            thread.Start();

            Go('x');
        }

        private static void Go(char symbol)
        {
            for (int i = 0; i < 450; i++)
                Console.Write(symbol);
        }
    }
}