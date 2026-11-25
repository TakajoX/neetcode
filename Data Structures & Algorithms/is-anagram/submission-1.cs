public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        List<char> str1 = new List<char>();
        List<char> str2 = new List<char>();

        foreach (var item in s)
        {
            str1.Add(item);
        }

        foreach (var item in t)
        {
            str2.Add(item);
        }

        for (int i = 0; i < str1.Count; i++)
        {
            for (int y = 0; y < str2.Count; y++)
            {
                if (str1[i] == str2[y])
                {
                    str1.RemoveAt(i);
                    str2.RemoveAt(y);
                    i--;
                    break;
                }
            }
        }

        if (str1.Count == 0 && str2.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}