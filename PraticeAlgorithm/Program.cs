using PraticeAlgorithm.Problems.Problem003_GroupAnagrams;

public class Program
{
    static void Main()
    {
        Problem003_GroupAnagrams problem = new Problem003_GroupAnagrams();
        var result = problem.Solve02(["eat", "tea", "tan", "ate", "nat", "bat"]);
    }
}