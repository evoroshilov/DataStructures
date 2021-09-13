namespace ArrayProductsAllElements
{
    public class Solution
    {
        //Given an array, return an array where each index stores the product of all numbers except the number on the index itself.
        //Sample Input arr = {1,2,3,4}
        //Sample Output arr = {24,12,8,6}
        public static int[] FindProduct(int[] arr)
        {
            var temp = 1;

            // Allocation of result array
            var result = new int [arr.Length];

            // Product of elements on left side excluding arr[i]
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = temp;
                temp *= arr[i];
            }

            // Initializing temp to 1 for product on right side
            temp = 1;

            // Product of elements on right side excluding arr[i] 
            for (int i = arr.Length-1; i>= 0; i--)
            {
                result[i] *= temp;
                temp *= arr[i];
            }

            //Time Complexity O(n)
            //Space Complexity O(n)
            return result;
        }
    }
}