namespace Dice
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            int sum = await DeciRollAsync();

            Console.WriteLine($"Your dice roll result is {sum}");
        }

        static Random rn = new Random();

        public static async Task<int> DeciRollAsync()
        {
            Console.WriteLine("Dice rolling...");

            int roll1 = await RollAsync();
            int roll2 = await RollAsync();

            return roll1 + roll2;
        }

        public static async Task<int> RollAsync()
        {
            await Task.Delay(500);

            int diceRoll = rn.Next(1, 7);

            return diceRoll;
        }
    }
}