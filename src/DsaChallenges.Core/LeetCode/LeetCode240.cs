namespace DsaChallenges.Core.LeetCode;

public static class LeetCode240
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int row = 0;
        int cols = matrix[0].Length -1;

        while (row < matrix.Length && cols >= 0)
        {
            if (target == matrix[row][cols])
                return true;
            else if (target > matrix[row][cols])
                row++;
            else
                cols--;
        }
        return false;
    }

}
