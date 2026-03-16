using PraticeAlgorithm.Problems.Problem002_ValidAnagram;

[TestClass]
public class Problem02_ValidAnagramTests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void Solve_ShouldReturnExpected(string s, string t, bool expected)
    {
        var solution = new Problem002_ValidAnaGram();
        var result = solution.Solve(s, t);
        Assert.AreEqual(expected, result);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        var relative = Path.Combine("TestData", "Problem02_TestCases.csv");
        var path = FindFileUpwards(relative, Directory.GetCurrentDirectory());
        if (path is null)
            throw new FileNotFoundException($"Could not find '{relative}'. Searched starting at '{Directory.GetCurrentDirectory()}' and moving up parent directories.");

        foreach (var line in File.ReadLines(path).Skip(1))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var parts = line.Split(',');
            // Expecting: s,t,expected
            string s = parts.Length > 0 ? parts[0].Trim() : string.Empty;
            string t = parts.Length > 1 ? parts[1].Trim() : string.Empty;
            bool expected = parts.Length > 2 ? bool.Parse(parts[2].Trim()) : false;
            yield return new object[] { s, t, expected };
        }
    }

    private static string? FindFileUpwards(string relativePath, string startDirectory)
    {
        var dir = new DirectoryInfo(startDirectory);
        while (dir != null)
        {
            var candidate = Path.Combine(dir.FullName, relativePath);
            if (File.Exists(candidate)) return candidate;
            dir = dir.Parent;
        }
        return null;
    }
}
