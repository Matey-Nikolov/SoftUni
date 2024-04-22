namespace Set_Cover
{
    public class Program
    {
        static void Main()
        {
            int[] universe = { 1, 3, 5, 7, 9, 11, 20, 30, 40 };
            int[][] sets =
            {
                new int[] { 20 },
                new int[] { 1, 5, 20, 30 },
                new int[] { 3, 7, 20, 30, 40 },
                new int[] { 9, 30 },
                new int[] { 11, 20, 30, 40 },
                new int[] { 3, 7, 40 },
            };

            HashSet<int[]> result = SetCover(sets, universe);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        public static HashSet<int[]> SetCover(int[][] sets, int[] universe)
        {
            HashSet<int[]> selectedSets = new HashSet<int[]>();

            HashSet<int> universeSet = new HashSet<int>(universe);

            while (universeSet.Count > 0)
            {
                int[] currentSet = sets.OrderByDescending(a => universeSet.Intersect(a).Count()).First();


                selectedSets.Add(currentSet);

                sets = sets.Where(s => s != currentSet).ToArray();

                foreach (var item in currentSet)
                {
                    universeSet.Remove(item);
                }
            }

            return selectedSets;
        }
    }
}