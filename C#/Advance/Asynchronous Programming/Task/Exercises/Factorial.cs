namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Task<int> sumFactorial = Task<int>.Run(() =>
            {
                return FindFactorial(number);
            });

            Console.WriteLine($"Factorial of {number} is: {sumFactorial.Result}");
        }

        static int FindFactorial(int x)
        {
            int sum = 1;

            while (x != 1)
            {
                sum = sum * x;

                x--;
            }

            return sum;
        }
    }
}