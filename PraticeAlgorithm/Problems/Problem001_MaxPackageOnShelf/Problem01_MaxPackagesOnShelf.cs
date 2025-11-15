using PraticeAlgorithm.Interfaces;
namespace PraticeAlgorithm.Problems
{
    public class Problem01_MaxWaitedPackages : IProblem<int[], int>
    {
        public int Solve(int[] client)
        {
            int n = client.Length;
            HashSet<int> shelf = new HashSet<int>();
            int maxShelf = 0;
            int index = 0;

            for (int package = 1; package <= n; package++)
            {
                shelf.Add(package);

                while (index < n && shelf.Contains(client[index]))
                {
                    shelf.Remove(client[index]);
                    index++;
                }
                maxShelf = Math.Max(maxShelf, shelf.Count);
            }
            return maxShelf;
        }
    }
}