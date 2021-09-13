using Xunit;

namespace FirstNonRepeatingIntegerInArray.Test
{
    public class SolutionTest   
    {
        [Fact]
        public void FindFirstUniqueTest()
        {
            int[] arr = { 9, 2, 3, 2, 6, 6,9 };
            var result = Solution.FindFirstUnique(arr);
            Assert.Equal(3, result);
        }
    }
}
