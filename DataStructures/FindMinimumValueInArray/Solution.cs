namespace FindMinimumValueInArray
{
    public class Solution
    {
        //Given an array of size "n", can you find the minimum value in the array?
        //Sample Input  arr = {9, 2, 3, 6}
        //Sample Output 2
        public static int FindMinimum(int[] arr)
        {
            var min = arr[0];

            //At every Index compare its value with minimum and if its less 
            //then make that index value new minimum value

            foreach (var item in arr)
            {
                if(min > item)
                    min = item;
            }

            //Since the entire list is iterated over once, this algorithm is in linear time, O(n)O(n).
            return min;
        }
    }
}
