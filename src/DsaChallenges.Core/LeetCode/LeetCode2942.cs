namespace Challenges.src.LeetCode
{
    public static class LeetCode2942
    {
        public static IList<int> FindWordsContaining(string[] words, char x)
        {
            var list = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
