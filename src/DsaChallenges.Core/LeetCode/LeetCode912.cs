namespace DsaChallenges.Core.LeetCode;

public static class LeetCode912
{
    public static int[] SortArray(int[] nums)
    {
        Quicksort(nums, 0, nums.Length - 1);
        return nums;
    }

    private static void Quicksort(int[] arr, int begin, int end)
    {
        if (begin < end)
        {
            var rand = new Random();
            var pivotIndex = rand.Next(begin, end + 1);
            (arr[pivotIndex], arr[end]) =  (arr[end], arr[pivotIndex]);
                                 
            var partIndex = Partition(arr, begin, end);
            Quicksort(arr, begin, partIndex - 1);
            Quicksort(arr, partIndex + 1, end);
        }
    }

    private static int Partition(int[] arr, int begin, int end)
    {
        var pivot = arr[end];
        var i = (begin - 1);

        for (var j = begin; j < end; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[end]) = (arr[end], arr[i + 1]);

        return i + 1;
    }
}