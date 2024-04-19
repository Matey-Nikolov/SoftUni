namespace Bulbs
{
    public class Program
    {
        static void Main()
        {
            int[] bulbs = new int[] { 0, 1, 0, 1 };

            int result = MinSwitches(bulbs);
            Console.WriteLine(result);
        }

        public static int MinSwitches(int[] bulbs)
        {
            int count = 0;
            int state = 0;

            foreach (var bulb in bulbs)
            {
                if ((state % 2 == 0 && bulb == 0) || (state % 2 == 1 && bulb == 1))
                {
                    count++;
                    state++;
                }
            }

            return count;
        }
    }
}