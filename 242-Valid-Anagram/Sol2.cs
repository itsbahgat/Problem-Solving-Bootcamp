public class Solution {
    public bool IsAnagram(string s, string t) {
        
        char[] chars= s.ToCharArray();
        char[] chars2= t.ToCharArray();
        Array.Sort(chars);
        Array.Sort(chars2);
        if (chars.SequenceEqual(chars2))
            return true;

        return false;
    }
}