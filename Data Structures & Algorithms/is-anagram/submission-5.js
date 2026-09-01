class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if(s == null || t == null) {
            return false;
        }

        if(s.length != t.length) {
            return false;
        }

        var x = s.toLowerCase();
        var y = t.toLowerCase();

        x = s.split("").sort().join("");
        y = t.split("").sort().join("");


        if(x.includes(y)) {
            return true;
        }

        return false;    


    }
}
