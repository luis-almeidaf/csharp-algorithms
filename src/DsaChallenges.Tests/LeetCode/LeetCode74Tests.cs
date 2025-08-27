using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode74Tests
{
    [Fact]
    public void Should_Return_True_When_Target_Is_Found()
    {
        int[][] matrix = [[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]];
        var target = 8;
        var result = LeetCode74.SearchMatrix(matrix, target);
        Assert.True(result);
    }

    [Fact]
    public void Should_Return_False_When_Target_Is_Not_Found()
    {
        int[][] matrix = [[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]];
        var target = 15;
        var result = LeetCode74.SearchMatrix(matrix, target);
        Assert.False(result);
    }
}
