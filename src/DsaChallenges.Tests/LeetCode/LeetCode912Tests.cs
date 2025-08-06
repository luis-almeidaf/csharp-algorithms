using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode
{
    public class LeetCode912Tests
    {
        [Theory]
        [InlineData(new int[] { 5, 2, 3, 1 }, new int[] { 1, 2, 3, 5 })]
        [InlineData(new int[] { 100, 900, 3, 1, 2, 10, 0 }, new int[] { 0, 1, 2, 3, 10, 100, 900 })]
        [InlineData(new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 1 }, new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 })]
        public void ShouldSortArrayInAscendingOrder_WhenUnsortedArrayIsGiven(int[] nums, int[] expectedResult)
        {
            var result = LeetCode912.SortArray(nums);
            Assert.Equal(expectedResult, result);
        }
    }
}
