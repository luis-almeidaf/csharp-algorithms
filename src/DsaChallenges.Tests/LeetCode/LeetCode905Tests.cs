using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode
{
    public class LeetCode905Tests
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4 }, new int[] { 2, 4, 1, 3 })]
        [InlineData(new int[] { 1, 0 }, new int[] { 0, 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void ShouldPlaceEvenNumbersBeforeOddNumbers_WhenArrayHasMixedValues(int[] nums, int[] expectedResult)
        {
            var result = LeetCode905.SortArrayByParity(nums);
            Assert.Equal(expectedResult, result);
        }

    }
}
