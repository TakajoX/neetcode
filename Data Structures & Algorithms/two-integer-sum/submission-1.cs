public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        
        for (int i = 0; i < nums.Length; i++) {
            int helper = target - nums[i];
            for (int y = i + 1; y < nums.Length; y++) {
                if (helper == nums[y]) {
                    return new int[] {i, y};
                }
            }
        }

        return new int[0];
        
    }
}
