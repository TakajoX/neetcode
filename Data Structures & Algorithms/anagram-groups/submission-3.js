class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        const map = new Map();

        for (let i = 0; i < strs.length; i++) {
            const currentWord = strs[i];
            const key = currentWord.split("").sort().join("");

            if (!map.has(key)) {
                map.set(key, []);
            }

            map.get(key).push(currentWord);
        }

        return Array.from(map.values());
    }
}