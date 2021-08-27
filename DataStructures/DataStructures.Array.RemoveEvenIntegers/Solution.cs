using System;

namespace RemoveEvenIntegers
{
    //Time Complexity:
    //Since the entire array has to be iterated over, this solution is in O(n).
    public static class Solution
    {
        public static int[] RemoveEven(int[] arr)
        {
            var oddNumbers = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 1)
                    oddNumbers++;
            }

            var oddArray = new int[oddNumbers];

            var index = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 1)
                    oddArray[index++] = item;
            }

            return oddArray; // change this and return the correct result array
        }
    }
}
