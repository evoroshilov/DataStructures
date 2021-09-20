namespace FindSecondMaximumValueInArray
{
    public class Solution
    {
        //Given an array of size n, can you find the second maximum element in the array?
        //Sample Input arr = {9,2,3,6}
        //Sample Output arr = {6}
        public static int FindSecondMaximum(int[] arr)
        {
            var max = int.MinValue;
            var secondMax = int.MinValue;

            for(int i=0; i<arr.Length; i++)
            {
                // Keep track of Maximum value, whenever the value at an array index is greater
                // than current Maximum value then make that max value 2nd max value and
                // make that index value maximum value  

                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];                    
                }else if(arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }

            //This solution is in O(n)O(n) since the list is traversed once only.
            return secondMax;
        }
    }
}
