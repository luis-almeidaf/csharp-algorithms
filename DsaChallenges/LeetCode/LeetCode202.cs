namespace DsaChallenges.LeetCode
{
    public class LeetCode202
    {
        public bool isHappy(int n)
        {
            HashSet<int> visited = new HashSet<int>();

            while (!visited.Contains(n))
            {
                visited.Add(n);
                n = SumOfSquares(n);

                if (n == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }
    }
}
