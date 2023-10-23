namespace Sum_with_Task
{
    internal class Program
    {
        static void Main()
        {
            Task<double> task = Task<double>.Run(() =>
            {
                return Computation(10);
            });

            Console.WriteLine($"{task.Result:f2}");
        }

        private static double Computation(double end)
        {
            double sum = 0;

            for (int i = 0; i < end; i++)
            {
                sum += i * 1.1;
            }

            return sum;
        }
    }
}