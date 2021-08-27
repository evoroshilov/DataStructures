namespace MergeTwoSortedArrays
{
    //Time Complexity:
    //The time complexity for this algorithm is O(n+m)O(n+m), where nn and mm are the sizes of arr1 and arr2, respectively.
    //This is because both arrays are iterated over once.
    public static class Solution
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var result = new int [arr1.Length + arr2.Length];
            
            // Traverse both array 
            while (i < arr1.Length && j < arr2.Length)
            {
                // Check if current element of first 
                // array is smaller than current element 
                // of second array. If yes, store first 
                // array element and increment first array 
                // index. Otherwise do same with second array 
                
                var first = arr1[i];
                var second = arr2[j];

                if (first > second)
                {
                    result[k++] = second;
                    j++;
                }
                else
                {
                    result[k++] = first;
                    i++;
                }
            }

            // Store remaining elements of first array 
            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }
            
            // Store remaining elements of second array 
            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }

            return result;
        }
    }
}
