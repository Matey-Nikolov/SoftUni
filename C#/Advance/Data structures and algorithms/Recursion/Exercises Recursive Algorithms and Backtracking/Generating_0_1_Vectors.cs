namespace Generating_0_1_Vectors
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];


            GenerateVectoRecursive(nums, 0);
        }

        // 0 0 0 0 0 0 0 0 0 - всички възмжни комбинации
        private static void GenerateVectoRecursive(int[] nums, int index)
        {
            if (index > nums.Length - 1)
            {
                Console.WriteLine(string.Join("", nums));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                nums[index] = i;
                GenerateVectoRecursive(nums, index + 1);
            }
        }
    }
}