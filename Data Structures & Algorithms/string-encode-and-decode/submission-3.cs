public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach(string s in strs) {
            sb.Append(s.Length);
            sb.Append(',');
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string>decodedStrs = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int commaIndex = s.IndexOf(',', i);

            int length = int.Parse(s.Substring(i, commaIndex - i));

            string word = s.Substring(commaIndex + 1, length);
            decodedStrs.Add(word);

            i = commaIndex + 1 + length;
        }

        return decodedStrs;
   }
}
