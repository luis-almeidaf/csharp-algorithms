using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode240Tests
{
    [Fact]
    public void Should_Return_True_When_Target_Is_Found()
    {
        int[][] matrix = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
        var target = 19;
        var result = LeetCode240.SearchMatrix(matrix, target);
        Assert.True(result);
    }

    [Fact]
    public void Should_Return_False_When_Target_Is_Not_Found()
    {
        int[][] matrix = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
        var target = 100;
        var result = LeetCode240.SearchMatrix(matrix, target);
        Assert.False(result);
    }
}
