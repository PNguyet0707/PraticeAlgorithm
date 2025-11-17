
namespace PraticeAlgorithm.Problems.Problem004_TopKFrequentElements
{
    public class TopKFrequentElements
    {
        public int[] Solve(int[] nums, int k)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> countNums = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                countNums[num] = countNums.GetValueOrDefault(num, 0) + 1;
            }
            countNums = countNums.OrderByDescending(x => x.Value).ToDictionary();
            for (int i = 0; i < k; i++)
            {
                result.Add(countNums.ElementAt(i).Key);
            }
            return result.ToArray();

        }
        // Min Heap
        public int[] Solve01(int[] nums, int k)
        {
            int[] result = new int[k];
            Dictionary<int, int> countNums = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                countNums[num] = countNums.GetValueOrDefault(num, 0) + 1;
            }
            var pq = new PriorityQueue<int, int>();
            foreach (var kv in countNums)
            {
                pq.Enqueue(kv.Key, kv.Value);
                if (pq.Count > k)
                    pq.Dequeue();
            }
            for (int i = k - 1; i >= 0; i--)
            {
                result[i] = pq.Dequeue();
            }
            return result;
        }
        // Buckets sort
        public int[] Solve02(int[] nums, int k)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> countNums = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                countNums[num] = countNums.GetValueOrDefault(num, 0) + 1;
            }
           
            List<int>[] buckets = new List<int>[nums.Length + 1];
            foreach (var i in countNums)
            {
                int count = i.Value;
                if (buckets[count] is null)
                    buckets[count] = [i.Key];
                else
                    buckets[count].Add(i.Key);
            }
            for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
            {
                if (buckets[i] is null)
                    continue;
                foreach (var num in buckets[i])
                {
                    result.Add(num);
                    if (result.Count == k) break;
                }
            }
            return result.ToArray();
        }        
    }
}
