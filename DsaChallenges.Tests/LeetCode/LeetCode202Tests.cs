using DsaChallenges.LeetCode;

namespace DsaChallenges.Tests.LeetCode
{
    public class LeetCode202Tests
    {
        [Theory]
        [InlineData(100, true)]
        [InlineData(37, false)]
        [InlineData(0, false)]
        [InlineData(19, true)]
        public void Should_Validate_If_Number_Is_Happy(int n, bool expectedResult)
        {
            var leetcode202 = new LeetCode202();
            var result = leetcode202.isHappy(n);
            Assert.Equal(expectedResult, result);
        }
    }
}
