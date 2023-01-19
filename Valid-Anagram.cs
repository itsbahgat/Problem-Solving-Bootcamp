public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length == t.Length && String.Concat(s.OrderBy(c => c)) == String.Concat(t.OrderBy(c => c)))
    {
        return true;
    }

        return false;
    }
}
