using Xunit;

namespace ArrayProductsAllElements.Test
{
    public class SolutionTest
    {
        [Fact]
        public void FindProductTest()
        {
            int[] arr = { 1, 2, 3, 4 };
            var result = Solution.FindProduct(arr);

            Assert.Equal(24, result[0]);
            Assert.Equal(12, result[1]);
            Assert.Equal(8,result[2]);
            Assert.Equal(6,result[3]);
        }
    }
}
