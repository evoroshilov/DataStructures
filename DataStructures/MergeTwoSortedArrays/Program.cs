using System;

namespace MergeTwoSortedArrays
{
    static class Program
    { 
        //Time Complexity:
       //The time complexity for this algorithm is O(n+m)O(n+m), where nn and mm are the sizes of arr1 and arr2, respectively.
       //This is because both arrays are iterated over once.
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 4, 5 };
            int[] arr2 = { 2, 6, 7, 8 };
            //expected result {1, 2, 3, 4, 5, 6, 7, 8}
            var result = Solution.MergeArrays(arr1, arr2);
            Console.WriteLine($"[{string.Join(',',result)}]");
            Console.Read();
        }
    }
}