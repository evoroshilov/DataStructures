using Xunit;

namespace FindMinimumValueInArray.Test
{
    public class SolutionTest
    {
        [Fact]
        public void FindMinimumTest()
        {
            int[] arr = { 8, 4, 5, 8,3,2,56 };
            var result = Solution.FindMinimum(arr);

            Assert.Equal(2, result);          
        }
    }
}
