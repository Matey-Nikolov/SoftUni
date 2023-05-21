namespace Action_Point
{
    public class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = Console.WriteLine;
            Array.ForEach(names, print);
        }
    }
}