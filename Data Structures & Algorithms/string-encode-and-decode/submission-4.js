class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {

        var encoded_string = "";
        var word_length = 0;

        for (let i = 0; i<strs.length; i++) {
            word_length = strs[i].length;
            encoded_string = encoded_string.concat(word_length, "#", strs[i]);
        }

        return encoded_string;
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {
        let decoded_strs = [];
        let i = 0;

        while (i < str.length) {
            let delimiter = str.indexOf("#", i);

            let length = parseInt(str.substring(i, delimiter));

            let word = str.slice(delimiter + 1, delimiter + 1 + length);

            decoded_strs.push(word);

            i = delimiter + 1 + length;

        }        
        
        return decoded_strs;
    }
}
