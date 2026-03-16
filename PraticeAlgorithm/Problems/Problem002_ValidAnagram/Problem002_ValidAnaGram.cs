namespace PraticeAlgorithm.Problems.Problem002_ValidAnagram
{
    public static class Problem002_ValidAnaGram
    {
        public static bool Solve(string s,string t)
        {
                if (s.Length != t.Length)
                {
                    return false;
                }

                Dictionary<char, int> countS = new Dictionary<char, int>();
                Dictionary<char, int> countT = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
                    countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
                }
                return countS.Count == countT.Count && !countS.Except(countT).Any();
        }
        public static bool Solve2(string s, string t)
        {
            int[] letterCountS = GetLetterCount(s);
            int[] letterCountT = GetLetterCount(t);
            for(int i = 0; i < 26; i++)
            {
                if (letterCountS[i] != letterCountT[i])
                    return true;
            }
            return false;
        }
        public static int[] GetLetterCount(string str)
        {
            int[] result = new int[26];
            foreach (char c in str) 
            {
                int index = c - 'a';
                result[index] += 1;
            }
            return result;
        }
    }
}
