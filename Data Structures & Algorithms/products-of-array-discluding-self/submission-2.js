class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums) {

        const n = nums.length;
        let product = [];

        let prefix = 1;
        for(let i = 0; i<n; i++) {
            product[i] = prefix;
            prefix = prefix * nums[i]; 
        }

        let suffix = 1;
        for(let i = n -1; i>=0; i--) {
            product[i] = product[i] * suffix;
            suffix = suffix * nums[i];
        }

        return product;
    }
}
