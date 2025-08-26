namespace Challenges.src.LeetCode
{
    public static class LeetCode2161
    {
        public static int[] PivotArray(int[] nums, int pivot)
        {
            int[] result = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;

            for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
            {
                if (nums[i] < pivot)
                {
                    result[left] = nums[i];
                    left++;
                }
                if (nums[j] > pivot)
                {
                    result[right] = nums[j];
                    right--;
                }
            }
            while (left <= right)
            {
                result[left] = pivot;
                left++;
            }
            return result;
        }
    }
}
