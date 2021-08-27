using Xunit;

namespace RemoveEvenIntegers.Test
{
    public class SolutionTest
    {
        [Fact]
        public void RemoveEvenTest()
        {
            int[] arr = { 1, 2, 4, 5, 10, 6, 3, 50, 61 };
            var result = Solution.RemoveEven(arr);
            Assert.Equal(1, result[0]);
            Assert.Equal(5, result[1]);
            Assert.Equal(3, result[2]);
            Assert.Equal(61, result[3]);
            Assert.True(result.Length == 4);
        }
    }
}