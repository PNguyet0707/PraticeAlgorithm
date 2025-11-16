namespace PraticeAlgorithm.Problems.Problem003_GroupAnagrams
{
    public class Problem003_GroupAnagrams
    {
        public List<List<string>> Solve(List<string> strs)
        {
            Dictionary<string,List<string>> result = new Dictionary<string,List<string> >();
            foreach (string str in strs)
            {
                var sortedStr = new string(str.OrderBy(s => s).ToArray());
                if(!result.ContainsKey(sortedStr))
                {
                    result[sortedStr] = [str];
                }
                else
                {
                    result[sortedStr].Add(str);
                }
            }
            return result.Values.ToList();
        }
        public List<List<string>> Solve02(List<string> strs)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                int[] charCount =  new int[26]; 
                foreach(char c in str)
                {
                    charCount[c-'a'] ++;
                }
                string countStr = string.Join(",", charCount);
                if(!result.ContainsKey(countStr))
                {
                    result[countStr] = [str];
                }
                else
                {
                    result[countStr].Add(str);
                }
            }
            return result.Values.ToList();
        }
    }
}
