using Challenges.src.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode2161Tests
{
    [Theory]
    [InlineData(new int[] { 9, 12, 5, 10, 14, 3, 10 }, 10, new int[] { 9, 5, 3, 10, 10, 12, 14 })]
    [InlineData(new int[] { -3, 4, 3, 2 }, 2, new int[] { -3, 2, 4, 3 })]
    [InlineData(new int[] { -1, 9, 3, 8, 6, 9, 5 }, 6, new int[] { -1, 3, 5, 6, 9, 8, 9 })]
    public void Should_Partition_Array_Around_Pivot_Theoryy(int[] nums, int pivot, int[] expected)
    {
        int[] result = LeetCode2161.PivotArray(nums, pivot);
        Assert.Equal(expected, result);
    }
}
