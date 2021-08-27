using System;

namespace RemoveEvenIntegers
{
    static class Program
    { 
        //Time Complexity:
        //Since the entire array has to be iterated over, this solution is in O(n).
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 10, 6, 3 };
            //expected output {1, 5, 3}
            var result = Solution.RemoveEven(arr);
            Console.WriteLine($"[{string.Join(',',result)}]");
            Console.Read();
        }
    }
}
