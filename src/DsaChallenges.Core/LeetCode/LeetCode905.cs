namespace DsaChallenges.Core.LeetCode
{
    public static class LeetCode905
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            var result = new int[nums.Length];
            int right = nums.Length - 1;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[left] = nums[i];
                    left++;
                }
                else
                {
                    result[right] = nums[i];
                    right--;
                }
            }
            return result;
        }
    }
}
