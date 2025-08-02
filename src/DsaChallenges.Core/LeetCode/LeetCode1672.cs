namespace DsaChallenges.Core.LeetCode;

public static class LeetCode1672
{
    public static int MaximumWealth(int[][] accounts)
    {
        var maxWealth = 0;
        foreach (var account in accounts)
        {
            var sumWealth = 0;
            foreach (var wealth in account)
            {
                sumWealth += wealth;
                if (sumWealth > maxWealth)
                    maxWealth = sumWealth;
            }
        }
        return maxWealth;
    }
}

