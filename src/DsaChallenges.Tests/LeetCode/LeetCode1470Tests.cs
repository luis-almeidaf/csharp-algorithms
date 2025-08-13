using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode1470Tests
{
    [Fact]
    public void ShouldShuffleTheArrayBasedOnTheInput()
    {
        int n = 3;
        var nums = new int[] { 2, 5, 1, 3, 4, 7 };
        var result = LeetCode1470.Shuffle(nums, n);
        Assert.Equal([2, 3, 5, 4, 1, 7], result);
    }
}
