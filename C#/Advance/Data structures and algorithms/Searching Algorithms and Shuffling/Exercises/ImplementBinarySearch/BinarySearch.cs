using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementBinarySearch
{
    public class BinarySearch
    {
        public int IndexOf(int[] arrayNumber, int key)
        {
            int leftIndex = 0;
            int rightIndex = arrayNumber.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int midlleIndex = (leftIndex + rightIndex) / +2;
                if (key < arrayNumber[midlleIndex])
                {
                    rightIndex = midlleIndex - 1;
                }
                else if (key > arrayNumber[midlleIndex])
                {
                    leftIndex = midlleIndex + 1;
                }
                else
                {
                    return midlleIndex;
                }
            }

            return -1;
        }
    }
}
