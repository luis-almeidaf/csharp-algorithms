namespace DsaChallenges.Core.LeetCode;

public static class LeetCode704
{
    public static int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length -1;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            var guess = nums[mid];
            if (guess == target)
            {
                return mid;
            }
            if (guess < target)
            {
                left = mid + 1;
            }
            if (guess > target)
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}