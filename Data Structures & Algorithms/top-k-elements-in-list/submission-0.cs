public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> maps = new Dictionary<int, int>();

        foreach(var n in nums) {
            if (maps.ContainsKey(n)) {
                maps[n]++;
            } else {
                maps.Add(n, 1);
            }
        }

        return maps.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
