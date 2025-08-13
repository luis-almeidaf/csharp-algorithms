﻿namespace DsaChallenges.Core.LeetCode;

public static class LeetCode1470
{
    public static int[] Shuffle(int[] nums, int n)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < n; i++)
        {
            result[2 * i] = nums[i];
            result[2 * i + 1] = nums[i + n];
        }
        return result;
    }
}
