class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {
        const map = new Map();

        for(let i = 0; i<nums.length; i++) {
            const currentNumber = nums [i];
            const key = currentNumber;

            if(!map.has(key)) {
                map.set(key, 1)
            } else {
                map.set(key, map.get(key) + 1)
            }

        }

        const entries = Array.from(map.entries());

        entries.sort((a, b) => b[1] - a[1]);

        const result = [];
        for(let i = 0; i<k; i++) {
            result.push(entries[i][0]);
        }

        return result;
    }
}
