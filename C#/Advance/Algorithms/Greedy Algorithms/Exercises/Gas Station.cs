namespace Gas_Station
{
    public class Program
    {
        static void Main()
        {

        }

        public static void GasStation()
        {
            double[] gas = new double[] { 1, 2 };
            double[] distance = new double[] { 2, 1 };

            Dictionary<int, int> proportions = new Dictionary<int, int>();

            for (int i = 0; i < gas.Length; i++)
            {
                if (!proportions.ContainsKey(i))
                {
                    proportions[i] = 0;
                }

                //proportions[i] = gas[i] / distance[i];
            }
        }
    }
}