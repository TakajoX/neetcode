public class Solution {
    public bool IsValid(string s) {

        if(s.Length < 2) {
            return false;
        }

        Stack<char> parentheses = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                parentheses.Push(s[i]);
            } else {

                if (parentheses.Count == 0) {
                    return false;
                }

                char lastOpened = parentheses.Pop();

                if (s[i] == ')' && lastOpened != '(') {
                    return false;
                } else if (s[i] == ']' && lastOpened != '[') {
                    return false;
                } else if (s[i] == '}' && lastOpened != '{') {
                    return false;
                }
            }
        }

        return parentheses.Count == 0;
    }
}
