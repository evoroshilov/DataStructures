using Xunit;

namespace FindTwoNumbers.Test
{
    public class SolutionTest
    {
        [Fact]
        public void MergeTwoSortedArrays()
        {
            var sum = 27;
            int[] arr = { 1, 21, 3, 14, 5, 60, 7, 6 };
            var result = Solution.FindSum(arr, sum);
            var result1 = Solution.FindSum2(arr, sum);
            Assert.Equal(sum, result1[0]+result1[1]);
        }
    }
}