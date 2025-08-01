using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode217Test
{
    [Theory]
    [InlineData(new int[] {1, 2, 3, 4 , 1}, true)]
    [InlineData(new int[] {1, 2, 3, 4 , 5}, false)]
    public void ContainsDuplicate_Should_Validate_If_An_Array_Contains_Duplicate_Numbers(int[] nums, bool expectedResult)
    {
        var leetCode271 = new LeetCode217();
        var result = leetCode271.ContainsDuplicate(nums);
        Assert.Equal(expectedResult, result);

    }
}