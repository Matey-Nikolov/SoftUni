namespace Knights_of_Honor
{
    public class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = name => Console.WriteLine($"Sir {name}");
            Array.ForEach(names, print);
        }
    }
}