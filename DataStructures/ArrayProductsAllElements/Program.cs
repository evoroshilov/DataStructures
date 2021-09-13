using System;

namespace ArrayProductsAllElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4 };
            var result = Solution.FindProduct(arr);
            Console.WriteLine($"[{String.Join(',',result)}]");
        }
    }
}