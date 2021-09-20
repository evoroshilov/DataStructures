using Xunit;

namespace FindSecondMaximumValueInArray.Test
{
    public class SolutionTest
    {
        [Fact]
        public static void FindSecondMaximumTest()
        {
           var result =  Solution.FindSecondMaximum(new int[] { 15,5, 3, 1, 4, 8, 56,54 });
           Assert.Equal(54, result);
        }
    }
}
