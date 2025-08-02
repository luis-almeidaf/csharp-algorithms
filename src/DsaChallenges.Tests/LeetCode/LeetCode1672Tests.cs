using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode1672Tests
{
    [Fact]
    public void Should_ReturnMaximumWealth_WhenSingleCustomer()
    {
        int[][] accounts = [[1, 2, 3]];
        var res = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(6, res);
    }

    [Fact]
    public void Should_ReturnMaximumWealth_WhenMultipleCustomers()
    {
        int[][] accounts = [[1, 5, 20], [5, 6, 7], [9, 10]];
        var res = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(26, res);
    }

    [Fact]
    public void Should_ReturnCorrectWealth_WhenWealthIsSameForAllCustomers()
    {
        int[][] accounts = [[1, 2, 3], [1, 2, 3]];
        var res = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(6, res);
    }

    [Fact]
    public void Should_ReturnZero_WhenAllAccountsAreEmpty()
    {
        int[][] accounts = [[], [], []];
        var res = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(0, res);
    }
}