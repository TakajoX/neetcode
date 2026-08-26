class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        var duplicate
        for(var i = 0; i<nums.length; i++) {
            duplicate = nums[i];
            for(var x = i + 1; x<nums.length; x++) {
                if(duplicate == nums[x]) {
                    return true;
                }
            }
        }

        return false;
    }
}
