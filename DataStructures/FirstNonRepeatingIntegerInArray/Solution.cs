using System.Collections.Generic;

namespace FirstNonRepeatingIntegerInArray
{
    //Given an array, find the first integer, which is unique in the array. Unique means the number does not repeat and appears only once in the whole array.
    //Sample Input arr = {9, 2, 3, 2, 6, 6}
    //Sample Output 9
    public class Solution
    {
        public static int FindFirstUnique(int[] arr)
        {
            int result = 0;
            
            var dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                {
                    dict.Add(item, 1);
                }
            }            

            foreach (var item in dict)
            {
                if (dict[item.Key] <= 1)
                    return item.Key;
            }

            return -1;
        }
    }
}
