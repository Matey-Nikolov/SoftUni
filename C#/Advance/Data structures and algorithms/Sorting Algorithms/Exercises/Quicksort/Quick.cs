namespace Quicksort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quick
    {
        public void QuickSort(int[] arrayNumbers, int lowNumber, int hightNumber)
        {
            if (lowNumber < hightNumber)
            {
                int findPivot = Partition(arrayNumbers, lowNumber, hightNumber);

                QuickSort(arrayNumbers, lowNumber, findPivot - 1);
                QuickSort(arrayNumbers, findPivot + 1, hightNumber);
            }
        }


        private static int Partition(int[] arrayNumbers, int lowNumber, int hightNumber)
        {
            int pivot = arrayNumbers[hightNumber];
            int i = lowNumber - 1;

            for (int j = lowNumber; j < hightNumber; j++)
            {
                if (arrayNumbers[j] <= pivot)
                {
                    i++;
                    Swap(arrayNumbers, i, j);
                }
            }

            Swap(arrayNumbers, i + 1, hightNumber);

            return i + 1;
        }
        
        private static void Swap(int[] numbers, int currentIndex1, int currentIndex2)
        {
            int oldNumber = numbers[currentIndex1];
            numbers[currentIndex1] = numbers[currentIndex2];
            numbers[currentIndex2] = oldNumber;
        }
       
    }
}