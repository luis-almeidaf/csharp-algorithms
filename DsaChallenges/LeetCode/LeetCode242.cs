namespace DsaChallenges.LeetCode
{
    public class LeetCode242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var dictS = new Dictionary<char, int>();
            var dictT = new Dictionary<char, int>();

            foreach (char charS in s)
            {
                if (!dictS.TryAdd(charS,1))
                {
                    dictS[charS]++;
                }
            }

            foreach (char charT in t)
            {
                if (!dictT.TryAdd(charT,1))
                {
                    dictT[charT]++;
                }
            }

            return dictS.Count == dictT.Count && !dictS.Except(dictT).Any();
        }
    }
}
