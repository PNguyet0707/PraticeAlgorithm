using PraticeAlgorithm.Problems;
using Xunit;
using Assert = Xunit.Assert;

public class Problem01_MaxWaitedPackagesTests
{
    
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Solve_ShouldReturnExpected(int[] input, int expected)
    {
        // Arrange
        var solution = new Problem01_MaxWaitedPackages();

        // Act
        var result = solution.Solve(input);

        // Assert
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        //System.Diagnostics.Debugger.Launch();
        var path = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "TestCases.csv");

        foreach (var line in File.ReadLines(path).Skip(1)) 
        {
            var parts = line.Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(p => p.Trim()).ToArray();
            int expected = int.Parse(parts[^1]);
            int[] input = parts.Take(parts.Length - 1).Select(int.Parse).ToArray();

            yield return new object[] { input, expected };
        }
    }
}
