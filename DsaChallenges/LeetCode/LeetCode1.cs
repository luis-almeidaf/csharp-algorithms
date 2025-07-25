namespace DsaChallenges.LeetCode
{
    public class LeetCode1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                {
                    return [dict[diff], i];
                }
                dict.TryAdd(nums[i], i);
            }
            return [];
        }
    }
}
