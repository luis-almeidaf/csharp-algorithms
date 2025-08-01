using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode1Tests
{
    [Fact]
    public void Should_ReturnIndices_When_TwoNumbersSumToTarget()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int target = 9;
        var result = LeetCode1.TwoSum(nums, target);
        Assert.Equal([3, 4], result);
    }

    [Fact]
    public void Should_ReturnFirstMatchingIndices_When_MultiplePairsExist()
    {
        int[] nums = { 1, 3, 2, 4, 5, 3, 3 };
        int target = 6;
        var result = LeetCode1.TwoSum(nums, target);
        Assert.Equal([2, 3], result);
    }

    [Fact]
    public void Should_ReturnEmptyResult_When_NoPairMatchesTarget()
    {
        int[] nums = { 1, 1, 1, 1, 1 };
        int target = 0;
        var result = LeetCode1.TwoSum(nums, target);
        Assert.Equal([], result);
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 0, new int[] { })]
    [InlineData(new int[] { 3, 3, 1, 5, 1 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 2, 0, 3, 5, 1 }, 6, new int[] { 3, 4 })]
    [InlineData(new int[] { 0, 1, 0, 5, 1 }, 0, new int[] { 0, 2 })]
    public void Should_ReturnCorrectIndices_ForVariousInputScenarios(int[] nums, int target, int[] expected)
    {
        var result = LeetCode1.TwoSum(nums, target);
        Console.WriteLine(result.ToList());
        Assert.Equal(expected, result);
    }
}