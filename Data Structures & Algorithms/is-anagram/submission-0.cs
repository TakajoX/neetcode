public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        char[] str1 = s.ToCharArray();
        char[] str2 = t.ToCharArray();

        Array.Sort(str1);
        Array.Sort(str2);

        return str1.SequenceEqual(str2);


    }
}
