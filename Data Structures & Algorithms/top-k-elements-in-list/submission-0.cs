public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach(int n in nums) {
            if(counts.ContainsKey(n)) {
                counts[n]++;
            } else {
                counts[n] = 1;
            }
        }

        return counts.OrderByDescending(x => x.Value)
                        .Take(k)
                        .Select(x => x.Key)
                        .ToArray();
    }
}
