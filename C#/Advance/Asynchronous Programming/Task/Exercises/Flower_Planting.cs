namespace Flower_Planting
{
    internal class Program
    {
        static void Main()
        {
            int difficultPlot = int.Parse(Console.ReadLine());

            Task task = Task.Run(() =>
            {
                Seed(difficultPlot);
            });

            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }

        static void Seed(int plots)
        {
            for (int i = 0; i < 16; i++)
            {
                if (i == plots)
                    throw new Exception("Something went wrong with seeding");

                Console.WriteLine($"Seeding {i} plot.");
            }
        }
    }
}