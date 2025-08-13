using DsaChallenges.Core.LeetCode;

namespace DsaChallenges.Tests.LeetCode;

public class LeetCode1672Tests
{
    [Fact]
    public void Should_ReturnMaximumWealth_WhenSingleCustomer()
    {
        var accounts = new int[][] { [1, 2, 3] };
        var result = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Should_ReturnMaximumWealth_WhenMultipleCustomers()
    {
        var accounts = new int[][] { [1, 5, 20], [5, 6, 7], [9, 10] };
        var result = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(26, result);
    }

    [Fact]
    public void Should_ReturnCorrectWealth_WhenWealthIsSameForAllCustomers()
    {
        var accounts = new int[][] { [1, 2, 3], [1, 2, 3] };
        var result = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Should_ReturnZero_WhenAllAccountsAreEmpty()
    {
        var accounts = new int[][] { [], [], [] };
        var result = LeetCode1672.MaximumWealth(accounts);
        Assert.Equal(0, result);
    }
}