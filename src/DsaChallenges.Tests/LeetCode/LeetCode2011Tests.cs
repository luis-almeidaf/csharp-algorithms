using Challenges.src.LeetCode;

namespace DsaChallenges.Tests.LeetCode
{
    public class LeetCode2011Tests
    {
        [Theory]
        [InlineData(new string[] { "--X", "X++", "X++" }, 1)]
        [InlineData(new string[] { "--X", "X--", "X++" }, -1)]
        [InlineData(new string[] { "++X", "X++", "X++" }, 3)]
        [InlineData(new string[] { "--X", "X++", "X++", "X--" }, 0)]
        [InlineData(new string[] { "--Teste", "++", "Teste++", "-", "++++" }, 1)]
        public void Should_Return_Correct_Value_When_Multiple_Increments_And_Decrements(string[] operations, int expected)
        {
            var result = LeetCode2011.FinalValueAfterOperations(operations);
            Assert.Equal(expected, result);
        }
    }
}
