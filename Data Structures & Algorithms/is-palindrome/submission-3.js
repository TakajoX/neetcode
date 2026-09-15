class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {
        let str = s.toLowerCase();
        const validChars = "abcdefghijklmnopqrstuvwxyz0123456789";
        let cleanedStr = "";

        for (let char of str) {
            if (validChars.includes(char)) {
                cleanedStr = cleanedStr + char;
            }
        }

        let reversedStr = "";
        for (let i = cleanedStr.length - 1; i >= 0; i--) {
            reversedStr = reversedStr + cleanedStr[i];
        }

        return cleanedStr === reversedStr;
    }
}