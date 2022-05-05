namespace MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSortClass
    {
        private static int[] auxiliaryArray;
       // private static bool IsLess;

        public static void Sort(int[] arrayNumbers)
        {
            auxiliaryArray = new int[arrayNumbers.Length];
            Sort(arrayNumbers, 0 , arrayNumbers.Length - 1);
        }

        private static void Sort(int[] arrayNumbers, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }

            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

            Sort(arrayNumbers, leftIndex, middleIndex);
            Sort(arrayNumbers, middleIndex + 1, rightIndex);
            Merge(arrayNumbers, leftIndex, middleIndex, rightIndex);
        }

        private static void Merge(int[] arrayNumbers, int leftIndex, int middleIndex, int rightIndex)
        {
            if (IsLess(arrayNumbers[middleIndex], arrayNumbers[middleIndex + 1]))
            {
                return;
            }

            for (int index = leftIndex; index < rightIndex + 1; index++)
            {
                auxiliaryArray[index] = arrayNumbers[index];
            }

            int i = leftIndex;
            int j = middleIndex + 1;

            for (int currentIndex = leftIndex; currentIndex <= rightIndex; currentIndex++)
            {
                if (i > middleIndex)
                {
                    arrayNumbers[currentIndex] = auxiliaryArray[j++];
                }
                else if (j > rightIndex)
                {
                    arrayNumbers[currentIndex] = auxiliaryArray[i++];
                }
                else if (IsLess(auxiliaryArray[i], auxiliaryArray[j]))
                {
                    arrayNumbers[currentIndex] = auxiliaryArray[i++];
                }
                else
                {
                    arrayNumbers[currentIndex] = auxiliaryArray[j++];
                }
            }
        }

        public static bool IsLess(int current, int currentIndex)
        {
            return current.CompareTo(currentIndex) < 0;
        }
    }
}