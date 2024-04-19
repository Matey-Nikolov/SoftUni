using System.Linq;

namespace Sum_of_Coins
{
    public class Program
    {
       // private static List<int> coins = new List<int>() { 1, 2, 5, 10, 20, 50 };
        //private static Dictionary<int, int> countCoinUse = new Dictionary<int, int>();
        
        static void Main()
        {
            /*
            int targetSum = 923;

            List<int> set = new List<int>();

            bool returnTrueOrFalse = CoinsSum(targetSum, set);

            if (returnTrueOrFalse)
            {
                Console.WriteLine($"Number of coins to take: {set.Count}");

                foreach (var keyValue in countCoinUse)
                {
                    Console.WriteLine($"{keyValue.Value} coin(s) with value {keyValue.Key}");
                }
            }
            else
            {
                Console.WriteLine($"Error");

            }
            */
        }

        /*
        public static bool CoinsSum(int targetSum, List<int> set)
        {

            int currentSum = 0;

            coins = coins.OrderByDescending(x => x).ToList();

            foreach (var coin in coins)
            {
                while (currentSum + coin <= targetSum)
                {
                    set.Add(coin);
                    currentSum += coin;

                    if (!countCoinUse.ContainsKey(coin))
                    {
                        countCoinUse.Add(coin, 0);
                    }
                        countCoinUse[coin]++;
                }
            }

            if (currentSum >= targetSum)
            {
                return true;
            }

            return false;
        }
        */
    }
}