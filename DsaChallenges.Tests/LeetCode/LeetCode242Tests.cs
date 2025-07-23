using DsaChallenges.LeetCode;

namespace DsaChallenges.Tests.LeetCode
{
    public class LeetCode242Tests
    {
        [Theory]
        [InlineData("touro", "outro", true)]
        [InlineData("touro", "outra", false)]
        [InlineData("touro", "outros", false)]
        [InlineData("aabb", "abab", true)]
        [InlineData("", "", true)]
        public void Should_Validate_If_Words_Are_Anagrams(string t, string s, bool expectedResult)
        {
            var leetcode242 = new LeetCode242();
            var result = leetcode242.IsAnagram(s, t);
            Assert.Equal(expectedResult, result);
        }
    }
}
