using Xunit;

namespace MergeTwoSortedArrays.Test
{
    public class SolutionTest
    {
        [Fact]
        public void MergeTwoSortedArrays()
        {
            int[] arr1 = { 1, 3, 4, 5 };
            int[] arr2 = { 2, 6, 7, 8 };
            //expected result {1, 2, 3, 4, 5, 6, 7, 8}
            var result = Solution.MergeArrays(arr1, arr2);
            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(3, result[2]);
            Assert.Equal(4, result[3]);
            Assert.Equal(5, result[4]);
            Assert.Equal(6, result[5]);
            Assert.Equal(8, result[7]);
        }
    }
}