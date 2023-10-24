namespace Forward_and_Back
{
    public class Program
    {
        public static List<char> ListA = new List<char>() { 'o', 'o', 'x', 'o', 'o' };

        static void Main()
        {
            Thread threadOne = new Thread(() => Forward());
            threadOne.Start();

            Thread threadTwo = new Thread(() => Back());
            threadTwo.Start();

            threadOne.Join();
            threadTwo.Join();
        }

        private static void Forward()
        {
            Thread.Sleep(50);
            ListA[4] = 'f';
            Console.WriteLine(string.Join(' ', ListA));
        }

        private static void Back()
        {
            Thread.Sleep(100);
            ListA[4] = 'o';
            ListA[1] = 'b';
            Console.WriteLine(string.Join(' ', ListA));
        }
    }
}