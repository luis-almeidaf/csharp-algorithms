using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode704Tests
{
    [Theory]
    [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new int[] { -5, 0, 1, 4, 10, 12, 14,17, 20 }, 0, 1)] 
    public void Should_ReturnIndex_When_TargetExists(int[] nums, int target, int expectedResult)
    {
        var result = LeetCode704.Search(nums, target);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Should_ReturnMinusOne_When_TargetNotFound()
    {
        int[] nums = [-1, 0, 3, 5, 9, 12];
        var target = 2;
        var result = LeetCode704.Search(nums, target);
        Assert.Equal(-1, result);
    }
    
}
