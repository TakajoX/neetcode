public class Solution {
    public bool IsPalindrome(string s) {


        string cleanS = new string(s 
            .Where(c => char.IsLetterOrDigit(c))
            .Select(c => char.ToLower(c))
            .ToArray());

        
        string reverseCleanS = new string(cleanS.Reverse().ToArray());

        if(cleanS == reverseCleanS) {
            return true;
        }

        return false;
    }
}
