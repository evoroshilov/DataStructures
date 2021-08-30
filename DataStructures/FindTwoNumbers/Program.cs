using System;

namespace FindTwoNumbers // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 21, 3, 14, 5, 60, 7, 6 };
            var result = Solution.FindSum(arr, 27);
            Console.WriteLine($"[{String.Join(',',result)}]");
            
            int[] arr1 = { 1, 21, 3, 14, 5, 60, 7, 6 };
            var result1 = Solution.FindSum2(arr, 27);
            Console.WriteLine($"[{String.Join(',',result1)}]");
            Console.Read();
        }
    }
}