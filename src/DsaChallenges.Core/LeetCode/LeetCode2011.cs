namespace Challenges.src.LeetCode
{
    public static class LeetCode2011
    {
        public static int FinalValueAfterOperations(string[] operations)
        {
            int count = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i].Contains('+'))
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return count;
        }
    }
}
