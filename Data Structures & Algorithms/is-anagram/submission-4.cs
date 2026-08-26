public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

        List<char> l = new List<char>();

        foreach(var item in s) {
            l.Add(item);
        }

        for(int i = 0; i < t.Length; i++) {
            if(l.Contains(t[i])) {
                l.Remove(t[i]);
            }
        }

        if(l.Count == 0) {
            return true;
        }else {
            return false;
        }

    }
}
