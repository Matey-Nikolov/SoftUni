namespace Boom
{
    public class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            Thread thread = new Thread(() => ContainsNumbers(inputText));
            thread.Start();
            thread.Join();
        }

        private static void ContainsNumbers(string inputText)
        {
            try
            {
                foreach (char item in inputText)
                {
                    if (char.IsDigit(item))
                    {
                        throw new Exception("Boom");
                    }
                }

                Console.WriteLine("There are no bombs in the text.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}