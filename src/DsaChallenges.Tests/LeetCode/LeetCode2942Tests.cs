using Challenges.src.LeetCode;

namespace DsaChallenges.Tests.LeetCode
{
    public class LeetCode2942Tests
    {
        [Fact]
        public void Should_Return_Indices_Of_Words_Containing_Char()
        {
            var words = new string[] { "leet", "code" };
            char x = 'e';
            var expected = new List<int> { 0, 1 };

            var result = LeetCode2942.FindWordsContaining(words, x);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_Return_Empty_List_When_No_Words_Contain_Char()
        {
            var words = new string[] { "teste", "retorno" };
            char x = 'u';
            var expected = new List<int> { };

            var result = LeetCode2942.FindWordsContaining(words, x);
            Assert.Equal(expected, result);
        }
    }
}
