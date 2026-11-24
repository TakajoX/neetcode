public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> maps = new Dictionary<int, int>();

        foreach (var item in nums) {
            if (maps.ContainsKey(item)) {
                maps[item]++;
            } else {
                maps.Add(item, 1);
            }            
        }

        foreach (var item in maps) {
            if (item.Value > 1) {
                return true;
            }
        }

        return false;
            
        
    }
}