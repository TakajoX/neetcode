public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            char[] character = s.ToCharArray();
            Array.Sort(character);

            string str = new string(character);

            if (groups.ContainsKey(str)) {
                groups[str].Add(s);
            } else {
                groups.Add(str, new List<string> {s});
            }
        }

        return groups.Values.ToList();
    }
}