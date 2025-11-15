using PraticeAlgorithm.Problems;
using PraticeAlgorithm.Problems.Problem002_ValidAnagram;

public class Program
{
    static void Main()
    {
        Problem002_ValidAnaGram problem = new Problem002_ValidAnaGram();
        var result = problem.Solve("nagaram", "anagram");
    }
}