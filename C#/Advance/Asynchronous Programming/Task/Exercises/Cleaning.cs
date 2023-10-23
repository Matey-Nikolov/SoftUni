namespace Cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareFootage = double.Parse(Console.ReadLine());

            Task<double> vacuumingTask = Task<double>.Run(() =>
            {
                return Vacuuming(squareFootage);
            });

            Task<double> washingTask = Task<double>.Run(() =>
            {
                return Washing(squareFootage);
            });

           // vacuumingTask.Wait();
            //washingTask.Wait();

            double cleaningSum = vacuumingTask.Result + washingTask.Result;

            int hours = (int)cleaningSum / 60;
            int minutes = (int)cleaningSum % 60;

            Console.WriteLine($"Cleaning for {hours} hours and {minutes} minutes");
        }

        static double Washing(double squareFootage)
        {
            double washing = squareFootage * 1.5;
            return washing;
        }

        static double Vacuuming(double squareFootage)
        {
            double vacuumingTimeMinutes = squareFootage * 0.5;
            return vacuumingTimeMinutes;
        }
    }
}