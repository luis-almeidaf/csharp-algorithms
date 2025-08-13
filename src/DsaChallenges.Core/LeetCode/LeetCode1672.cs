namespace DsaChallenges.Core.LeetCode;

public static class LeetCode1672
{
    public static int MaximumWealth(int[][] accounts)
    {
        return accounts.Max(account => account.Sum());
    }
}

