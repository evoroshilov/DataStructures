using System;
using System.Collections.Generic;

namespace FindTwoNumbers
{
    
    //In this problem, you have to implement the int[] findSum(int[] arr, int n) method, which will take a number n, and an array arr as input and returns an array of two integers that add up to n in an array. You are required to return only one such pair. If no such pair is found then simply return the array.
    //Since the sorting function used in this code takes O(nlogn)O(nlogn) and the algorithm to find two numbers takes O(n) time, the overall time complexity of this code is O(nlognO(nlogn).
    public static class Solution
    {
        public static int[] FindSum(int[] arr, int n)
        {
            var hashSet = new HashSet<int>();
            foreach (var item in arr)
            {
                if (hashSet.Contains(n - item))
                    return new int[] { item, n - item };
                hashSet.Add(item);
            }

            return Array.Empty<int>();
        }
        
        public static int[] FindSum2(int[] arr, int n)
        {
            Array.Sort(arr);

            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var sum = arr[left] + arr[right]; //Calulate Sum of Pointer 1 and 2

                if (sum > n)
                    right--;
                else if (sum < n) //if sum is less than given value => Move Pointer 1 to Right
                    left++;
                else
                {
                    return new[] { arr[left], arr[right] };
                }
            }
            
            return Array.Empty<int>();
        }
    }
}