public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> ints = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {
            int complementare = target - nums[i];
            if(ints.ContainsKey(complementare)) {
                return new int[] {ints[complementare], i};
            } else {
                ints.Add(nums[i], i);
            }
        }

        return new int[0];
    }
}
